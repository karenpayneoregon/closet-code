using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SqlServerHelperLibrary.Classes
{
    public class Utilities
    {
        /// <summary> 
        /// Determine if a specific database exists on a known server 
        /// </summary> 
        /// <param name="server">Server name</param> 
        /// <param name="database">Database name</param> 
        /// <returns></returns> 
        public (bool success, Exception exception) DatabaseExists(string server, string database)
        {

            try
            {
                using SqlConnection cn = new()
                {
                    ConnectionString = 
                        ("Data Source=" + (server + ";Initial Catalog=master;Integrated Security=True;"))
                };
                using SqlCommand cmd = new()
                {
                    Connection = cn, 
                    CommandText = ("select * from master.dbo.sysdatabases where name='" + (database + "'"))
                };

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                return (reader.HasRows, null);

            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }

        /// <summary> 
        /// Determine if a table exist 
        /// </summary> 
        /// <param name="server">An available server</param> 
        /// <param name="database">An existing database</param> 
        /// <param name="tableName">Table name to check if exists or not</param> 
        /// <returns></returns> 
        public (bool success, Exception exception) TableExists(string server, string database, string tableName)
        {

            var connectionString = 
                $"Data Source={server};Initial Catalog={database};Integrated Security=True";

            try
            {
                using var cn = new SqlConnection { ConnectionString = connectionString };
                using var cmd = new SqlCommand { Connection = cn };

                cmd.CommandText = 
                    $"IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='{tableName}') " + 
                    "SELECT 1 ELSE SELECT 0";

                cn.Open();
                var result = Convert.ToInt32(cmd.ExecuteScalar());

                return (result == 1, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
            
        }

        /// <summary> 
        /// Get table names for a database that exists on an available SQL-Server 
        /// </summary> 
        /// <param name="server">Server name</param> 
        /// <param name="database">Database name</param> 
        /// <returns></returns> 
        public (List<string> names, Exception exception) TableNames(string server, string database)
        {

            var tableNames = new List<string>();
            var connectionString = 
                $"Data Source={server};Initial Catalog={database};Integrated Security=True";

            using var cn = new SqlConnection { ConnectionString = connectionString };
            using var cmd = new SqlCommand() { Connection = cn };

            cmd.CommandText =
                @"SELECT s.name, o.name 
                              FROM sys.objects o WITH(NOLOCK) 
                              JOIN sys.schemas s WITH(NOLOCK) 
                              ON o.schema_id = s.schema_id 
                              WHERE o.is_ms_shipped = 0 AND RTRIM(o.type) = 'U' 
                              ORDER BY s.name ASC, o.name ASC";

            try
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var tableName = reader.GetString(1);
                        if (!tableName.Contains("sysdiagrams"))
                        {
                            tableNames.Add(tableName);
                        }

                    }
                }

                return (tableNames, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }
    }
}
