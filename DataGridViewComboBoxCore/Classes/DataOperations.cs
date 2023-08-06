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
        var productsDataTable = new DataTable();
        var colorsDataTable = new DataTable();

        using SqlConnection cn = new() { ConnectionString = _connectionString };
        using SqlCommand cmd = new() { Connection = cn };
        cn.Open();

        cmd.CommandText = "SELECT id,Item,ColorId,CustomerId FROM Product";
        productsDataTable.Load(cmd.ExecuteReader());

        cmd.CommandText = "SELECT ColorId,ColorText FROM Colors ORDER BY ColorText";
        colorsDataTable.Load(cmd.ExecuteReader());

        // insert select option for new rows and is optional
        var colorDataRow = colorsDataTable.NewRow();
        colorDataRow[0] = -1;
        colorDataRow[1] = "Select";
        colorsDataTable.Rows.InsertAt(colorDataRow, 0);

        return (productsDataTable, colorsDataTable);

    }
}