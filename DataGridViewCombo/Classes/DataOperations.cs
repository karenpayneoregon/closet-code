using System.Data;
using System.Data.SqlClient;

namespace DataGridViewCombo1.Classes
{
    public class DataOperations
    {
        private static string ConnectionString = 
            "Data Source=.\\sqlexpress;Initial Catalog=DataGridViewCodeSample;Integrated Security=True";

        public static (DataTable customerTable, DataTable colorTable) LoadData()
        {
            var dtCustomer = new DataTable();
            var dtColor = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();

                    cmd.CommandText = "SELECT id,Item,ColorId,CustomerId FROM Product";
                    dtCustomer.Load(cmd.ExecuteReader());

                    cmd.CommandText = "SELECT ColorId,ColorText FROM Colors ORDER BY ColorText";
                    dtColor.Load(cmd.ExecuteReader());
                    var dr = dtColor.NewRow();
                    dr[0] = -1;
                    dr[1] = "Select";
                    dtColor.Rows.InsertAt(dr, 0);

                }
            }

            return (dtCustomer, dtColor);

        }

        public static void UpdateRow(DataRow dataRow)
        {
            // TODO
        }
    }
}
