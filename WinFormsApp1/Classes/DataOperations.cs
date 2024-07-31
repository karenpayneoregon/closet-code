using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1.Classes;
internal class DataOperations
{

    public static List<Category> Categories()
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        List<Category> list = new List<Category>();

        using var cn = new SqlConnection(connectionString);
        using var cmd = new SqlCommand { Connection = cn };
        cmd.CommandText = "SELECT CategoryID,CategoryName FROM dbo.Categories WHERE CategoryID < @Position";
        cmd.Parameters.Add("@Position", SqlDbType.Int).Value = 9;

        cn.Open();

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Category() {Id = reader.GetInt32(0), Name = reader.GetString(1)});
        }

        return list;

    }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString() => Name;
}
