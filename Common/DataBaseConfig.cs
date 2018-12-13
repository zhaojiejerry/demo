using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Common
{
    public class DataBaseConfig
    {
        private static string ConnectionString = @"server=127.0.0.1;port=3306;database=test;userid=root;password=jerry8199";
        public static IDbConnection Connection()
        {   
                IDbConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
                return conn;
        }

    }
}
