using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace PROJETO_FINAL_LC
{
    class DbAssistent
    {
        static String defaultConnectionString = "server = 127.0.0.1 ; user id = root ; " + 
                                                "password = 13579 ; database = myvideolog";
        String connectionString;
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dataReader;


        public DbAssistent(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbAssistent(String serverIp, String userId, String password, String database)
            :this("server = " + serverIp + " ; user id = " + userId + " ; password = " + password)
        {}

        public DbAssistent()
            :this(defaultConnectionString)
        {}

        public void setConnectionString(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Boolean openConnection(Type type, String openConnectionErrorMethod)
        {
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                return true;
            }
            catch (Exception ex)
            {
                if (type != null && openConnectionErrorMethod != null)
                {
                    invokeErrorMethod(type, openConnectionErrorMethod, ex, "Error opening connection");
                }
                return false;
            }
        }

        public Boolean openConnection()
        {
            return openConnection(null, null);
        }

        public Boolean connectionIsOpen()
        {
            return connection.State.Equals(System.Data.ConnectionState.Open);
        }

        public MySqlDataAdapter getAdapter(String commandString)
        {
            return new MySqlDataAdapter(commandString, connection);
        }

        public MySqlDataReader executeQuery(String commandString)
        {
            return executeQuery(commandString, null, null, null);
        }

        public MySqlDataReader executeQuery(String commandString, Type type,
                                            String executeQueryErrorMethod, String message)
        {
            command.CommandText = commandString;
            try
            {
                dataReader = command.ExecuteReader();
                return dataReader;
            }
            catch (Exception ex)
            {
                if (type != null && executeQueryErrorMethod != null)
                invokeErrorMethod(type, executeQueryErrorMethod, ex, message);
                return null;
            }
        }
     
        public Boolean executeNonQuery(String commandString, Type type,
                                       String executeNonQueryErrorMethod, String message)
        {
            command.Connection = connection;
            command.CommandText = commandString;
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                if (type != null && executeNonQueryErrorMethod != null)
                {
                    invokeErrorMethod(type, executeNonQueryErrorMethod, ex,
                        message);
                }
                return false;
            }
        }

        public Boolean executeNonQuery(String commandString)
        {
            return executeNonQuery(commandString, null, null, null);
        }

        public void closeConnection()
        {
            connection.Close();
        }

        private void invokeErrorMethod(Type type, String methodName, Exception ex, String message)
        {
            Object obj = Activator.CreateInstance(type);
            Object[] args = new Object[2];
            args[0] = ex;
            args[1] = message;
            type.InvokeMember(methodName, BindingFlags.InvokeMethod, null, obj, args);
        }
    
    }
}
