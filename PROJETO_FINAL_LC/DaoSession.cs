using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PROJETO_FINAL_LC
{
    class DaoSession : DbAssistent
    {

        public Boolean createTable()
        {
            return createTable(null, null);
        }

        public Boolean createTable(Type type, String errorMethod)
        {
            String createModeTableString = "CREATE TABLE IF NOT EXISTS MODE (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "name VARCHAR(30))";

            String createSessionTableString = "CREATE TABLE IF NOT EXISTS SESSION (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "userLogin VARCHAR(30) NOT NULL, " +
            "date DATE NOT NULL, " +
            "videoCode INTEGER NOT NULL, " +
            "evaluetion DECIMAL(5,2), " +
            "modeCode INTEGER, " +
            "comment VARCHAR(2048), " +
            "FOREIGN KEY (userLogin) references USER(login), " +
            "FOREIGN KEY (videoCode) references VIDEO(code), " +
            "FOREIGN KEY (modeCode) references MODE(code))";

            return
            executeNonQuery(createModeTableString, type, errorMethod, "Create MODE table failed.") &&
            executeNonQuery(createSessionTableString, type, errorMethod, "Create SESSION table failed.");
        }

        public List<String> retrieveAllModes()
        {
            List<String> modes = new List<string>();
            String retrieveModesCommand = "SELECT name FROM MODE";

            MySqlDataReader dataReader = executeQuery(retrieveModesCommand, this.GetType(), "er", "Erro ao recuperar modos");

            if (!dataReader.HasRows) return null;

            while (dataReader.Read())
            {
                modes.Add(dataReader["name"].ToString());
            }
            return modes;
        }

        public Boolean insertMode(String modeName)
        {
            return insertMode(modeName, null, null);
        }

        public Boolean insertMode(String modeName, Type type, String erroMethodName)
        {
            String insertModeString = "INSERT INTO MODE (name) " +
                                          "VALUES('" + modeName + "')";
            return executeNonQuery(insertModeString, type, erroMethodName, "Insert mode failed.");
        }

        public void er(Object obj, String message)
        {
            String errorString = "Um erro aconteceu.";
            if (obj is Exception)
            {
                Exception ex = (Exception)obj;
                errorString += " " + message + " " + ex.Message;
            }
            MessageBox.Show(errorString);

        }

        public Boolean updateSession(Session session)
        {
            return updateSession(session, null, null);
        }

        public Boolean updateSession(Session session, Type type, String errorMethod)
        {
            return false;
        }
        
        public Boolean insertSession(Session session)
        {
            return insertSession(session, null, null);
        }

        public Boolean insertSession(Session session, Type type, String errorMethod)
        {
            int modeCode;

            modeCode = getModeCode(session.getMode());

            String[] dateStrings = new String[2];
            String[] videoCodeStrings = new String[2];
            String[] userLoginStrings = new String[2];
            String[] evaluetionStrings = new String[2];
            String[] modeStrings = new String[2];
            String[] commentStrings = new String[2];

            if (session.getDate() != null)
            {
                dateStrings[0] = "date";
                dateStrings[1] = "'" + session.getDate() + "'";
            }
            else
                return false;

            if (session.getVideoCode() != -1)
            {
                videoCodeStrings[0] = ", videoCode";
                videoCodeStrings[1] = ", " + session.getVideoCode();
            }
            else 
                return false;

            if (!session.getUserLogin().Equals(""))
            {
                userLoginStrings[0] = ", userLogin";
                userLoginStrings[1] = ", '" + session.getUserLogin() + "'";
            }
            else
                return false;
            
            if (session.getEvaluetion() != -1)
            {
                evaluetionStrings[0] = ", evaluetion";
                evaluetionStrings[1] = ", " + session.getEvaluetion().ToString().Replace(",",".") + "";
            }
            
            if (modeCode != 0)
            {
                modeStrings[0] = ", modeCode";
                modeStrings[1] = ", " + modeCode;
            }

            if (!session.getComment().Equals(""))
            {
                commentStrings[0] = ", comment";
                commentStrings[1] = ", '" + session.getComment() + "'";
            }

            String insertSessionString = "INSERT INTO SESSION (" +
                                                         dateStrings[0] +
                                                         videoCodeStrings[0] +
                                                         userLoginStrings[0] + 
                                                         evaluetionStrings[0] +
                                                         modeStrings[0] +
                                                         commentStrings[0] + ") VALUES (" +
                                                         dateStrings[1] +
                                                         videoCodeStrings[1] +
                                                         userLoginStrings[1] +
                                                         evaluetionStrings[1] +
                                                         modeStrings[1] +
                                                         commentStrings[1] + ")";

//            MessageBox.Show(insertSessionString);
            Boolean insertionResult =
                executeNonQuery(insertSessionString, type, errorMethod, "Insert session failed.");

            session.setCode(getLastVideoCode());

            return insertionResult;
            
        }

        private int getModeCode(String modeName)
        {
            String getModeCodeCommand;
            getModeCodeCommand = "SELECT code FROM MODE WHERE name = '" + modeName + "'";
            MySqlDataReader dataReader = executeQuery(getModeCodeCommand);
            if (!dataReader.HasRows)
            {
                dataReader.Close();
                return 0;
            }
            else
            {
                dataReader.Read();
                int code = dataReader.GetInt16("code");
                dataReader.Close();
                return code;
            }
        }

        public int getLastVideoCode()
        {
            int lastCode = 0;
            DaoSession daoSession = new DaoSession();
            daoSession.openConnection();
            MySqlDataReader dataReader = daoSession.executeQuery("SHOW TABLE STATUS LIKE 'SESSION'");
            if (dataReader != null && dataReader.HasRows)
            {
                dataReader.Read();
                lastCode = dataReader.GetInt16("auto_increment") - 1;
            }
            daoSession.closeConnection();
            return lastCode;
        }

        public Session createSessionFromDataReader(MySqlDataReader dr)
        {
            Session session;
            String userLogin;
            int code = 0;
            DateTime date;
            String dateString;
            Video video;
            String mode;
            String comment;
            
            float evaluetion;
            
            if (dr.Equals(DBNull.Value)) return null;

            if (!dr["comment"].Equals(DBNull.Value))
                comment = dr.GetString("comment");
            else
                comment = "";

            if (dr["code"].Equals(DBNull.Value)) return null;
            code = dr.GetInt32("code");

            if (dr["userLogin"].Equals(DBNull.Value)) return null;
            userLogin = dr.GetString("userLogin");
            
            if (!dr["evaluetion"].Equals(DBNull.Value))
                evaluetion = (float)Convert.ToDouble(dr.GetDecimal("evaluetion"));
            else
                evaluetion = 0;

            DaoVideo daoVideo = new DaoVideo();
            daoVideo.openConnection();
            
            video = daoVideo.getVideoByCode(dr.GetInt32("videoCode"));

            date = dr.GetDateTime("date");
            dateString = date.Day + "/" + date.Month + "/" + date.Year;

            if (!dr["modeCode"].Equals(DBNull.Value))
                mode = getModeByCode(dr.GetInt32("modeCode"));
            else
                mode = "";

            session = new Session(userLogin, video, dateString, evaluetion, mode, comment);
            session.setCode(code);
            return session;
        }

        private String getModeByCode(int code)
        {
            String res;
            DaoSession daoSession = new DaoSession();
            daoSession.openConnection();
            MySqlDataReader modeDataReader = daoSession.executeQuery(
                "SELECT name FROM MODE WHERE code = " + code);
            if (modeDataReader == null || !modeDataReader.HasRows)
                return null;
            modeDataReader.Read();
            res = modeDataReader.GetString("name");
            daoSession.closeConnection();
            return res;
        }

        public List<Session> simpleQuery(String s, String login)
        {
            List<Session> sessions = new List<Session>();

            String whereString = "SESSION.userLogin = '" + login + "' AND ("
                               + "SESSION.evaluetion = '" + s + "' OR "
                               + "SESSION.comment LIKE '%" + s + "%' OR "
                               + "VIDEO.nationalTitle LIKE '%" + s + "%' OR "
                               + "VIDEO.originalTitle LIKE '%" + s + "%' OR "
                               + "VIDEO.director LIKE '%" + s + "%' OR "
                               + "MODE.name = '" + s + "' OR "
                               + "CATEGORY.name = '" + s + "' OR "
                               + "TAG.name = '" + s + "')";

            int intS;
            if (int.TryParse(s, out intS))
            {
                whereString += " OR VIDEO.duration = " + intS + " OR "
                            + "VIDEO.year = " + intS;
            }
            
            String simpleQueryString = "SELECT * FROM SESSION "
                                     + "JOIN MODE ON SESSION.modeCode = MODE.code "
                                     + "JOIN VIDEO ON SESSION.videoCode = VIDEO.code "
                                     + "JOIN CATEGORY ON VIDEO.categoryCode = CATEGORY.code "
                                     + "JOIN VIDEO_TAG ON VIDEO.code = VIDEO_TAG.videoCode "
                                     + "JOIN TAG ON VIDEO_TAG.tagCode = TAG.code "
                                     + "WHERE " + whereString + " GROUP BY SESSION.code";
 //           MessageBox.Show(simpleQueryString);


            MySqlDataReader dataReader = executeQuery(simpleQueryString, this.GetType(),
                "er", "Erro na intrução de consulta simples.");

            return getSessionsFromDataReader(dataReader);
        }

        public Session getSessionByCode(int code)
        {
            Session session = null;
            String getSessionByCodeString = "SELECT * FROM SESSION WHERE code = " + code;
            MySqlDataReader dr = executeQuery(getSessionByCodeString);
            if(dr != null && dr.HasRows)
            {
                dr.Read();
                session = createSessionFromDataReader(dr);
            }
            return session;
        }

        private List<Session> getSessionsFromDataReader(MySqlDataReader dataReader)
        {
            List<Session> sessions = new List<Session>();
            if (dataReader == null || !dataReader.HasRows)
                return null;

            while (dataReader.Read())
            {
                sessions.Add(createSessionFromDataReader(dataReader));
            }
            return sessions;
        }

        public void populateDataGridView(DataGridView dgv, String login)
        {
            List<Session> sessions = new List<Session>();
            String queryString = "SELECT "
                               + "SESSION.code, date, nationalTitle, evaluetion, director, CATEGORY.name "
                               + "FROM SESSION, VIDEO, CATEGORY, USER "
                               + "WHERE "
                               + "SESSION.videoCode = VIDEO.code AND "
                               + "SESSION.userLogin = '" + login + "' AND "
                               + "VIDEO.categoryCode = CATEGORY.code "
                               + "GROUP BY SESSION.code "
                               + "ORDER BY date";
    
            MySqlDataAdapter dataAdapter = getAdapter(queryString);
            if (dataAdapter.Equals(DBNull.Value)) return;            

            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dgv.DataSource = ds;
        }
    }
}
