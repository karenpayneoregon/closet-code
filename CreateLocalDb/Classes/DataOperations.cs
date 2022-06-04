using System;
using Microsoft.Data.SqlClient;

namespace CreateLocalDb.Classes
{
    class DataOperations
    {
        /// <summary>
        /// Change to match your path for the database
        /// </summary>
        public static string DataPath = @"C:\OED";
        public static string ConnectionString() 
            => @$"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TRIAL;Integrated Security=True";

        public static string MasterConnectionString() 
            => @$"Server=(localdb)\MSSQLLocalDB";

        public static void Create()
        {
            
            using var cn = new SqlConnection(MasterConnectionString());
            using var cmd = new SqlCommand() { Connection = cn };

            cmd.CommandText = @$"CREATE DATABASE[TRIAL] ON PRIMARY (NAME=TRIAL_A, FILENAME='{DataPath}\TRIAL_A.mdf)')
                                           LOG ON(NAME=TRIAL_log, FILENAME='{DataPath}\TRIAL_A.ldf')";

            try
            {
                
                cn.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Created");

            }
            catch (Exception localException)
            {
                Console.WriteLine(localException);
            }
        }

        /// <summary>
        /// Open connection
        /// </summary>
        public static void Open()
        {

            using var cn = new SqlConnection(ConnectionString());

            cn.Open();
            Console.WriteLine("Open");
            
        }

        /// <summary>
        /// Create tables and optionally populate
        /// </summary>
        public static void CreateTables()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Run select statements
        /// </summary>
        public static void ReadData()
        {
            throw new NotImplementedException();
        }
    }
}
