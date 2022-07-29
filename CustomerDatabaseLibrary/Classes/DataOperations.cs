using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Data.SqlClient;
using CustomerDatabaseLibrary.Models;

namespace CustomerDatabaseLibrary.Classes
{
    public class DataOperations
    {
        private static string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=CustomerDatabase;Integrated Security=True";

        public static IReadOnlyList<Genders> GendersList()
        {
            List<Genders> list = new() { new Genders() {id = -1, GenderType = "Select"}};

            using var cn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = "SELECT id, GenderType FROM dbo.Genders;" };
            cn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Genders() {id = reader.GetInt32(0), GenderType = reader.GetString(1) });
            }

            return list.ToImmutableList();
        }
        public static IReadOnlyList<ContactTypes> ContactTypesList()
        {
            List<ContactTypes> list = new() { new ContactTypes() { Identifier = -1, ContactType = "Select" } };

            using var cn = new SqlConnection(ConnectionString);
            using var cmd = new SqlCommand { Connection = cn, CommandText = "SELECT Identifier, ContactType FROM dbo.ContactTypes;" };
            cn.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ContactTypes() { Identifier = reader.GetInt32(0), ContactType = reader.GetString(1) });
            }

            return list.ToImmutableList();
        }

        /// <summary>
        /// Add new customer with no error checking
        /// </summary>
        /// <param name="customer"><see cref="Customer"/></param>
        public static void AddCustomer(Customer customer)
        {

            using var cn = new SqlConnection(ConnectionString);

            // insert new record, get new primary key
            using var cmd = new SqlCommand { Connection = cn, CommandText =
                @"INSERT INTO dbo.Customer (CompanyName, ContactName, ContactTypeIdentifier, GenderIdentifier) 
                  VALUES (@CompanyName,  @ContactName,  @ContactTypeIdentifier,  @GenderIdentifier);
                  SELECT CAST(scope_identity() AS int);"
            };


            cmd.Parameters.Add("@CompanyName", SqlDbType.NChar).Value = 
                customer.CompanyName;

            cmd.Parameters.Add("@ContactName", SqlDbType.NChar).Value = 
                customer.ContactName;

            cmd.Parameters.Add("@ContactTypeIdentifier", SqlDbType.Int).Value = 
                customer.ContactTypeIdentifier;

            cmd.Parameters.Add("@GenderIdentifier", SqlDbType.Int).Value = 
                customer.GenderIdentifier;
            
            cn.Open();

            customer.Identifier = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
