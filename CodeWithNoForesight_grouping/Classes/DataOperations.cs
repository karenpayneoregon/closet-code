using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWithNoForesight_grouping.Models;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace CodeWithNoForesight_grouping.Classes
{
    class DataOperations
    {


        public static List<BookItem> ReadBooks()
        {
            List<BookItem> list = new();
            using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
            using var cmd = new SqlCommand() { Connection = cn, CommandText = SelectStatement };

            cn.Open();

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                list.Add(new()
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    PriceRange = reader.GetString(3)
                });

            }
            return list;

        }

        private static string SelectStatement => $@"
SELECT Id, 
       Title, 
       Price,
       CASE
           WHEN Price < 10
           THEN 'Cheap'
           WHEN Price > 10 AND Price < 20
           THEN 'Medium'
           ELSE 'Expensive'
       END AS PriceRange
FROM book
WHERE Price IN
(
    SELECT Price
    FROM book
    GROUP BY Price
    HAVING COUNT(*) = 1
)
ORDER BY PriceRange";

    }
}
