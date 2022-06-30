using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DataAdapterFormApp.Classes
{
    public class Utilities
    {

        public static bool TableExists(string tableName)
        {
            using (var cn = new OleDbConnection() { ConnectionString = EmployeeOperations.ConnectionString })
            {
                var schema = cn.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                return schema.Rows.OfType<DataRow>().Any(row => 
                    string.Equals(row.ItemArray[2].ToString(), tableName, 
                        StringComparison.CurrentCultureIgnoreCase));
            }
        }
    }
}
