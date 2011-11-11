using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PROJETO_FINAL_LC
{
    class DaoUser : DbAssistent
    {
        public Boolean createTable()
        {
            return createTable(null, null);
        }

        public Boolean createTable(Type type, String errorMethod)
        {   
            String createTableString = "CREATE TABLE IF NOT EXISTS USER(" +
                                       "login VARCHAR(30) PRIMARY KEY, " +
                                       "password VARCHAR(30) NOT NULL, " +
                                       "name VARCHAR(70), " +
                                       "evaluetionMethod INTEGER, " +
                                       "higherLimit INTEGER, " +
                                       "lowerLimit INTEGER, " +
                                       "step VARCHAR(5))";
            return executeNonQuery(createTableString, type, errorMethod, "Create table USER failed.");
        }

        public Boolean insertUser(User user)
        {
            return insertUser(user, null, null);
        }

        public Boolean insertUser(User user, Type type, String errorMethod)
        {
            int evaluetionMethod;
            EvaluetionMethodInfo emInfo = user.getEvaluetionMethodInfo();
            if(user.getEvaluetionMethodInfo().getEvaluetionMethod().Equals(EvaluetionMethod.Grade))
                evaluetionMethod = 0;
            else
                evaluetionMethod = 1;	
            
            String insertUserString = "INSERT INTO USER (login, password, name, evaluetionMethod, " +
                                                         "higherLimit, lowerLimit, step) " +
                                                         "VALUES ('" +
                                                         user.getLogin() + "', '" +
                                                         user.getPassword() + "', '" +
                                                         user.getName() + "', " +
                                                         evaluetionMethod + ", " + 
                                                         emInfo.getHigherLimit() + ", " +
                                                         emInfo.getLowerLimit() + ", '" + 
                                                         emInfo.getStep().ToString() + "')";
            
            return executeNonQuery(insertUserString, type, errorMethod, "Insert user into databese failed.");
        }

        public User getUserByLogin(String login, Type type, String errorMethod)
        {
            String selectUserByLogin = "SELECT * FROM USER WHERE login = '" + login + "'";
            return createUserFromDataReader(executeQuery(selectUserByLogin, type, errorMethod,
                                            "Get user by login failed."));
        }

        public User getUserByLogin(String login)
        {
            return getUserByLogin(login, null, null);
        }

        private User createUserFromDataReader(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            dataReader.Read();
            User user = new User(dataReader["login"].ToString(), dataReader["password"].ToString(),
                        dataReader["name"].ToString());

            EvaluetionMethod em;
            int evaluetionMethod = dataReader.GetInt16("evaluetionMethod");

            if(evaluetionMethod == 0)
                em = EvaluetionMethod.Grade;
            else
                em = EvaluetionMethod.Stars;

            user.setEvaluetionMethodInfo(em, (float) dataReader.GetInt16("lowerLimit"),
                                             (float) dataReader.GetInt16("higherLimit"),
                                              float.Parse(dataReader["step"].ToString()));
            return user;
        }
    }
}
