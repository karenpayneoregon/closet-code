using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        {
            return @$"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TRIAL;Integrated Security=True";
        }
        public static string MasterConnectionString()
        {
            return @$"Server=(localdb)\MSSQLLocalDB";
        }
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
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }

        public static void Open()
        {
            using var cn = new SqlConnection(ConnectionString());
            cn.Open();
            Console.WriteLine("Open");
            
        }
    }
}
