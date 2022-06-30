using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdapterFormApp.Extensions;

namespace DataAdapterFormApp.Classes
{
    /// <summary>
    /// Code sample for
    /// 1. Loading a table from SQL-Server
    /// 2. Saving all changes
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class EmployeeOperations
    {
        public static string ConnectionString => 
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        private static SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter();
        private static readonly DataSet _dataSet = new DataSet();
        private static readonly SqlConnection connection = new SqlConnection(ConnectionString);
        public static readonly BindingSource BindingSource = new BindingSource();

        public static (bool success, Exception exception) Load()
        {
            try
            {
                var selectStatement = "SELECT id, FirstName, LastName, HiredDate FROM dbo.employee;";
                _sqlDataAdapter = new SqlDataAdapter(selectStatement, connection);

                _sqlDataAdapter.Fill(_dataSet);
                _ = new SqlCommandBuilder(_sqlDataAdapter);
                _sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                BindingSource.DataSource = _dataSet.Tables[0];

                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }

        public static DataRow Current()
        {
            return ((DataRowView)BindingSource.Current).Row;
        }

        public static DataTable DataTable() => (DataTable)BindingSource.DataSource;

        public static (int affected, Exception exception) SaveChanges()
        {
            var count = -1;
            try
            {
                count = _sqlDataAdapter.Update(_dataSet);

                var table = DataTable();

                /*
                 * Set primary key from private var
                 */
                for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
                {
                    if (table.Rows[rowIndex][0] == DBNull.Value)
                    {
                        table.Rows[rowIndex].SetField("id", table.Rows[rowIndex].ObjectIdentifier());
                    }
                }
            }
            catch (Exception ex)
            {
                return (count, ex);
            }

            return (count, null);
        }
    }
}
