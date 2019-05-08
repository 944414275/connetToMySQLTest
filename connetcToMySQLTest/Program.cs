using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace connetcToMySQLTest
{
    class Program
    {
        static MySqlConnection sqlcon;
        static string conStr; 

        static void Main(string[] args)
        {
            conStr = ConfigurationManager.AppSettings["mysqlConStr"];
            sqlcon = new MySqlConnection(conStr);
            try
            {
                sqlcon.Open();
                Console.WriteLine("已连接数据库");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
