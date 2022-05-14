using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataGridViewReadonlyCheckBox.Classes
{
    public class Operations
    {
        private static string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;" +
            "Integrated Security=True";

        public static List<Contact> Contacts()
        {
            List<Contact> list = new List<Contact>();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                string selectStatement = "SELECT TOP 10 C.FirstName + ' ' + C.LastName AS [Name], Countries.Name FROM Customers AS Cust INNER JOIN Contacts AS C ON Cust.ContactId = C.ContactId INNER JOIN Countries ON Cust.CountryIdentifier = Countries.CountryIdentifier;";
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Contact()
                        {
                            Name = reader.GetString(0), 
                            Country = reader.GetString(1), Checked = reader.GetString(1) != "Germany"
                        });
                    }
                }
            }


            return list;
        }

    }
}