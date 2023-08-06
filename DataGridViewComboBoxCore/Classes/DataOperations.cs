using System.Data;
using Microsoft.Data.SqlClient;

namespace DataGridViewComboBoxCore.Classes;

public class DataOperations
{
    private static string _connectionString =
        """
        Data Source=.\sqlexpress;
        Initial Catalog=DataGridViewCodeSample;
        Integrated Security=True;
        Encrypt=False
        """;

    public static (DataTable customerTable, DataTable colorTable) LoadData()
    {
        var customerDataTable = new DataTable();
        var colorsDataTable = new DataTable();

        using SqlConnection cn = new() { ConnectionString = _connectionString };
        using SqlCommand cmd = new() { Connection = cn };
        cn.Open();

        cmd.CommandText = "SELECT id,Item,ColorId,CustomerId FROM Product";
        customerDataTable.Load(cmd.ExecuteReader());

        cmd.CommandText = "SELECT ColorId,ColorText FROM Colors ORDER BY ColorText";
        colorsDataTable.Load(cmd.ExecuteReader());

        // insert select option for new rows and is optional
        var dr = colorsDataTable.NewRow();
        dr[0] = -1;
        dr[1] = "Select";
        colorsDataTable.Rows.InsertAt(dr, 0);

        return (customerDataTable, colorsDataTable);

    }
}