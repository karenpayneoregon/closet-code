using System.Data;
using Microsoft.Data.SqlClient;

namespace DataGridViewComboBoxCore.Classes
{
    public class DataOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=DataGridViewCodeSample;Integrated Security=True;Encrypt=False";

        public static (DataTable customerTable, DataTable colorTable) LoadData()
        {
            var dtCustomer = new DataTable();
            var dtColor = new DataTable();

            using SqlConnection cn = new() { ConnectionString = _connectionString };
            using SqlCommand cmd = new() { Connection = cn };
            cn.Open();

            cmd.CommandText = "SELECT id,Item,ColorId,CustomerId FROM Product";
            dtCustomer.Load(cmd.ExecuteReader());

            cmd.CommandText = "SELECT ColorId,ColorText FROM Colors ORDER BY ColorText";
            dtColor.Load(cmd.ExecuteReader());
            var dr = dtColor.NewRow();
            dr[0] = -1;
            dr[1] = "Select";
            dtColor.Rows.InsertAt(dr, 0);

            return (dtCustomer, dtColor);

        }


    }
}
