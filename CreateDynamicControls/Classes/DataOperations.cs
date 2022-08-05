using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDynamicControls.Classes.Containers;

namespace CreateDynamicControls.Classes
{
    /// <summary>
    /// 
    /// If those running this code have issues it's because
    /// a) you don't have SQL-Server
    /// b) did not create the database
    ///
    /// Code has been tested on
    /// - Windows 10 with SQL-Server Express edition
    /// - Windows 7 with SQL-Server Enterprise edition
    /// </summary>
    public class DataOperations
    {
        /// <summary>
        /// Data connection to database, change Data Source if not
        /// using SQLEXPRESS
        /// </summary>
        private static string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;" + 
            "Integrated Security=True";

        /// <summary>
        /// Read all categories
        /// </summary>
        /// <returns>list of categories</returns>
        public static List<Category> ReadCategories()
        {
            var list = new List<Category>();
            
            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                
                var selectStatement = "SELECT CategoryID, CategoryName FROM dbo.Categories;";
                
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Category() {Id = reader.GetInt32(0), Name = reader.GetString(1)});
                    }
                }
            }

            return list;
            
        }
        /// <summary>
        /// Read products by category identifier
        /// </summary>
        /// <param name="identifier">category identifier</param>
        /// <returns>list of products</returns>
        public static List<Product> ReadProducts(int identifier)
        {
            var list = new List<Product>();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {

                var selectStatement = "SELECT ProductID, ProductName FROM dbo.Products WHERE CategoryID = @Id ORDER BY ProductName";

                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cmd.Parameters.AddWithValue("@Id", identifier);
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Product() { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                    }
                }
            }

            return list;
            
        }
        public static List<Employee> ReadEmployees()
        {
            var list = new List<Employee>();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {

                var selectStatement = "SELECT EmployeeID, TitleOfCourtesy, FirstName, LastName, BirthDate FROM dbo.Employees;";

                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Employee()
                        {
                            Id = reader.GetInt32(0), 
                            TitleOfCourtesy = reader.GetString(1),
                            FirstName = reader.GetString(2), 
                            LastName = reader.GetString(3), 
                            BirthDate = reader.GetDateTime(4)
                        });
                    }
                }
            }

            return list;

        }
    }
}
