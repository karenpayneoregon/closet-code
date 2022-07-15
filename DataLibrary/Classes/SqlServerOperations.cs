
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.SqlClient;
using DataLibrary.Models;

namespace DataLibrary.Classes
{
    public class SqlServerOperations
    {
        protected static string ConnectionString = "Server=.\\SQLEXPRESS;Database=NorthWind2020;Integrated Security=true";

        public static List<Country> Countries()
        {
            List<Country> list = new List<Country> { new() {Id = -1, Name = "Select"} };

            using var cn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = "SELECT CountryIdentifier, [Name] FROM dbo.Countries;" };
            cn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Country() {Id = reader.GetInt32(0), Name = reader.GetString(1)});
            }

            return list;
        }
        public static IReadOnlyList<CountryItem> CountriesReadOnly()
        {
            List<CountryItem> list = new() { new CountryItem(-1, "Select") };

            using var cn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = "SELECT CountryIdentifier, [Name] FROM dbo.Countries;" };
            cn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new CountryItem(reader.GetInt32(0), reader.GetString(1)) );
            }

            return list.ToImmutableList();
        }
    }
}
