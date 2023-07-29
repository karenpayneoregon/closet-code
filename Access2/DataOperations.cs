using System.Data.OleDb;
using System.Data;

namespace Access2;

/// <summary>
/// Examples for insert and update
/// No exception handling, feel free to add
/// </summary>
internal class DataOperations
{
    /*
     * Points to a database in the same folder as the executable
     */
    public static string ConnectionString =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";

    public static DataTable GetAll()
    {
        DataTable table = new DataTable();
        using OleDbConnection cn = new() { ConnectionString = ConnectionString };
        using OleDbCommand cmd = new() { Connection = cn };
        cmd.CommandText = "SELECT Id, FirstName, LastName FROM Person";
        cn.Open();
        table.Load(cmd.ExecuteReader());
        return table;
    }
    public static (bool success, int) InsertRow(string firstName, string lastName)
    {

        using OleDbConnection cn = new() { ConnectionString = ConnectionString };
        using OleDbCommand cmd = new() { Connection = cn };

        /*
         * MS-Access parameters are ordinal position,
         * not named but we can still name them which
         * in a larger query makes it easy to identify
         * the parameters
         */
        cmd.Parameters.Add(new OleDbParameter
        {
            ParameterName = "@FirstName",
            DbType = DbType.String
        }).Value = firstName;

        cmd.Parameters.Add(new OleDbParameter
        {
            ParameterName = "@LastName",
            DbType = DbType.String
        }).Value = lastName;
            
        cmd.CommandText = 
            @"INSERT INTO Person (FirstName,LastName) 
                  VALUES (@FirstName, @LastName)";


        cn.Open();

        // insert new row
        int affected = cmd.ExecuteNonQuery();
        // validate insert worked
        if (affected == 1)
        {
            // insert successful, get new primary key
            cmd.CommandText = "SELECT @@Identity";
            cmd.Parameters.Clear();
            var reader = cmd.ExecuteReader();
            reader.Read();
            return (true, reader.GetInt32(0));
        }
        else
        {
            // insert failed
            return (false, -1);
        }
    }
    public static bool UpdateRow(int identifier, string firstName, string lastName)
    {

        using OleDbConnection cn = new() { ConnectionString = ConnectionString };
        using OleDbCommand cmd = new() { Connection = cn };

        cmd.Parameters.Add(new OleDbParameter
        {
            ParameterName = "@FirstName",
            DbType = DbType.String
        }).Value = firstName;

        cmd.Parameters.Add(new OleDbParameter
        {
            ParameterName = "@LastName",
            DbType = DbType.String
        }).Value = lastName;

        cmd.Parameters.Add(new OleDbParameter
        {
            ParameterName = "@Id",
            DbType = DbType.Int16
        }).Value = identifier;

        cmd.CommandText =
            @"UPDATE Person 
              SET FirstName = @FirstName, LastName = @LastName 
              WHERE id = @Id";


        cn.Open();

        return cmd.ExecuteNonQuery() == 1;
    }
}