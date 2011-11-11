using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PROJETO_FINAL_LC
{
    class DaoVideo : DbAssistent
    {
        public Boolean createTable()
        {
            return createTable(null, null);
        }

        public Boolean createTable(Type type, String errorMethod)
        {
            String createEpisodeTableString = "CREATE TABLE IF NOT EXISTS EPISODE (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "number INTEGER, " +
            "seasonNumber INTEGER, " +
            "name VARCHAR(70))";

            String createCategoryTableString = "CREATE TABLE IF NOT EXISTS CATEGORY (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "name VARCHAR(30))";
                
            String createVideoTableString = "CREATE TABLE IF NOT EXISTS VIDEO (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "originalTitle VARCHAR(70), " +
            "nationalTitle VARCHAR(70), " +
            "director VARCHAR(70), " +
            "duration INTEGER, " +
            "year INTEGER, " +
            "categoryCode INTEGER, " +
            "episodeCode INTEGER, " +
            "FOREIGN KEY (categoryCode) references CATEGORY(code), " +
            "FOREIGN KEY (episodeCode) references EPISODE(code))";

            String createTagTableString = "CREATE TABLE IF NOT EXISTS TAG (" +
            "code INTEGER PRIMARY KEY AUTO_INCREMENT, " +
            "name VARCHAR(30))";

            String createVideo_TagTableString = "CREATE TABLE IF NOT EXISTS VIDEO_TAG (" +
            "videoCode INTEGER, " + 
            "tagCode INTEGER, " +
            "PRIMARY KEY (videoCode, tagCode), " +
            "FOREIGN KEY (videoCode) references VIDEO(code), " +
            "FOREIGN KEY (tagCode) references TAG(code))";

            return
            executeNonQuery(createCategoryTableString, type, errorMethod, "Create CATEGORY table failed.") &&
            executeNonQuery(createEpisodeTableString, type, errorMethod, "Create EPISODE table failed.") &&
            executeNonQuery(createVideoTableString, type, errorMethod, "Create VIDEO table failed.") &&
            executeNonQuery(createTagTableString, type, errorMethod, "Create TAG table failed.") &&
                executeNonQuery(createVideo_TagTableString, type, errorMethod, "Create VIDEO_TAG table failed.");
        }

        public Boolean insertVideo(Video video)
        {
            return insertVideo(video, null, null);
        }

        public Boolean insertVideo(Video video, Type type, String errorMethod)
        {
            int categoryCode, episodeCode;

            //TODO: properly initialize episodeCode by accessing EPISODE tables

            categoryCode = getCategoryCode(video.getCategory());
            episodeCode = 0;

            String getCategoryCodeCommand = "(SELECT code FROM CATEGORY WHERE name = '" +
                                            video.getCategory() + "')";


            String[] originalTitleStrings = new String[2];
            String[] nationalTitleStrings = new String[2];
            String[] directorStrings = new String[2];
            String[] durationStrings = new String[2];
            String[] yearStrings = new String[2];
            String[] categoryStrings = new String[2];
            String[] episodeStrings = new String[2];

            if (video.getOriginalTitle().Length != 0)
            {
                originalTitleStrings[0] = "originalTitle";
                originalTitleStrings[1] = "'" + video.getOriginalTitle() + "'";

                if (video.getNationalTitle().Length != 0)
                {
                    nationalTitleStrings[0] = ", nationalTitle";
                    nationalTitleStrings[1] = ", '" + video.getNationalTitle() + "'";
                }
            }
            else
            {
                nationalTitleStrings[0] = "nationalTitle";
                nationalTitleStrings[1] = "'" + video.getNationalTitle() + "'";
            }

            if (video.getDirector().Length != 0)
            {
                directorStrings[0] = ", director";
                directorStrings[1] = ", '" + video.getDirector() + "'";
            }
            
            if (video.getDuration() != 0)
            {
                durationStrings[0] = ", duration";
                durationStrings[1] = ", " + video.getDuration();
            }
            
            if (video.getYear() != 0)
            {
                yearStrings[0] = ", year";
                yearStrings[1] = ", " + video.getYear();
            }

            if (categoryCode != 0)
            {
                categoryStrings[0] = ", categoryCode";
                categoryStrings[1] = ", " + categoryCode;
            }
         
            if (episodeCode != 0)
            {
                episodeStrings[0] = ", episodeCode";
                episodeStrings[1] = ", " + episodeCode;
            }
            
            String insertVideoString = "INSERT INTO VIDEO (" +
                                                         originalTitleStrings[0] + 
                                                         nationalTitleStrings[0] + 
                                                         directorStrings[0] +
                                                         durationStrings[0] +
                                                         yearStrings[0] + 
                                                         categoryStrings[0] + 
                                                         episodeStrings[0] + ") VALUES (" +
                                                         originalTitleStrings[1] +
                                                         nationalTitleStrings[1] +
                                                         directorStrings[1] +
                                                         durationStrings[1] +
                                                         yearStrings[1] + 
                                                         categoryStrings[1] + 
                                                         episodeStrings[1] + ")";

            return executeNonQuery(insertVideoString, type, errorMethod, "Insert video failed.") &&
                   relateVideoAndTags(video, type, errorMethod);
        }

        private Boolean relateVideoAndTags(Video video)
        {
            return relateVideoAndTags(video, null, null);
        }

        private Boolean relateVideoAndTags(Video video, Type type, String errorMethod)
        {
            if (video.getTags().Length == 0)
                return true;
            String insertVideo_TagCommand;
            MySqlDataReader dataReader = executeQuery("SHOW TABLE STATUS LIKE 'VIDEO'", type,
                                         errorMethod, "Failed to get VIDEO table status.");
            if(!dataReader.HasRows)
                return false;
            dataReader.Read();
            int videoCode = dataReader.GetInt16("AUTO_INCREMENT")-1;
            dataReader.Close();

            List<int> tagCodes;
            tagCodes = retrieveAllTagsCodes(video.getTags());
            
            foreach (int tagCode in tagCodes)
            {
                insertVideo_TagCommand = "INSERT INTO VIDEO_TAG (videoCode, tagCode) VALUES ('" +
                                    videoCode + "', '" +
                                    tagCode + "')";
                executeNonQuery(insertVideo_TagCommand, type, errorMethod, "Failed to insert entry on VIDEO_TAG");
            }
            return true;
        }

        public List<int> retrieveAllTagsCodes(String[] names)
        {
            return retrieveAllTagsCodes(names, null, null);
        }

        public List<int> retrieveAllTagsCodes(String[] names, Type type, String errorMethod)
        {
            int i;
            List<int> codes = new List<int>();
            String retrieveTagsCommand = "SELECT code FROM TAG WHERE name = '";
            


            for (i = 0; i < (names.Length - 1); i++)
            {
                retrieveTagsCommand += names[i] + "' OR name = '";
            }

            retrieveTagsCommand += names[i] + "'";

            MySqlDataReader dataReader = executeQuery(retrieveTagsCommand, type, errorMethod,
                "Failed to get codes from the TAG table.");

            if (!dataReader.HasRows) return null;

            while (dataReader.Read())
            {
                codes.Add(dataReader.GetInt16("code"));
            }
            dataReader.Close();
            return codes;
        }
        
        private int getCategoryCode(String categoryName)
        {
            String getCatecoryCodeCommand;
            getCatecoryCodeCommand = "SELECT code FROM CATEGORY WHERE name = '" + categoryName + "'";
            MySqlDataReader dataReader = executeQuery(getCatecoryCodeCommand);
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

        public Video getVideoByCode(int code, Type type, String errorMethod)
        {
            String selectVideoByCode = "SELECT * FROM VIDEO WHERE code = " + code;
            return createVideoFromDataReader(executeQuery(selectVideoByCode, type, errorMethod,
                                            "Retrieving video from database failed."));
        }

        public Video getVideoByCode(int code)
        {
            return getVideoByCode(code, null, null);
        }

        private Video createVideoFromDataReader(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            dataReader.Read();
            String getCategoryNameCommand = "SELECT name FROM CATEGORY WHERE code = " +
                              dataReader.GetInt16("categoryCode");
            String category = executeQuery(getCategoryNameCommand).ToString();
            MessageBox.Show("Category: " + category);
            return null;
            String[] tags = new String[0];

            Video video = new Video(dataReader["originalTitle"].ToString(), dataReader["nationalTitle"].ToString(),
                        dataReader["director"].ToString(),dataReader.GetInt16("year"), dataReader.GetInt16("duration"), 
                        category, tags);
            
        }

        public List<String> retrieveAllCategories()
        {
            List<String> categories = new List<string>();
            String retrieveCategoriesCommand = "SELECT name FROM CATEGORY";

            MySqlDataReader dataReader = executeQuery(retrieveCategoriesCommand);

            if (!dataReader.HasRows) return null;

            while (dataReader.Read())
            {
                categories.Add(dataReader["name"].ToString());
            }
            return categories;
        }

        public List<String> retrieveAllTags()
        {
            List<String> tags = new List<string>();
            String retrieveTagsCommand = "SELECT name FROM TAG";

            MySqlDataReader dataReader = executeQuery(retrieveTagsCommand);

            if (!dataReader.HasRows) return null;

            while (dataReader.Read())
            {
                tags.Add(dataReader["name"].ToString());
            }
            return tags; 
        }

        public Boolean insertCategory(String categoryName)
        {
            return insertCategory(categoryName, null, null);
        }

        public Boolean insertCategory(String categoryName, Type type, String erroMethodName)
        {
            String insertCategoryString = "INSERT INTO CATEGORY (name) " + 
                                          "VALUES('" + categoryName + "')";
            return executeNonQuery(insertCategoryString, type, erroMethodName, "Insert category failed.");
        }

        public Boolean insertTag(String tagName)
        {
            return insertTag(tagName, null, null);
        }

        public Boolean insertTag(String tagName, Type type, String erroMethodName)
        {
            String insertTagString = "INSERT INTO TAG (name) " +
                                          "VALUES('" + tagName + "')";
            return executeNonQuery(insertTagString, type, erroMethodName, "Insert tag failed.");
        }
    }
}
