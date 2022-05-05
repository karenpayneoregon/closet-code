using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReturningInformation.Models;
using SomeThirdPartyLibrary.Classes;

namespace ReturningInformation.Classes
{
    public class FileOperations
    {

        /// <summary>
        /// This method assumes no runtime exceptions while <see cref="GetCustomersSafe"/>
        /// is better as we can first see if the exception is not null
        /// </summary>
        public static List<Customer> GetCustomers()
        {
            var (customers, _) = JsonHelpers.JsonToList<Customer>("Customers.json");
            return customers;
        }
        /// <summary>
        /// For a real application this is the correct way to get the data yield 
        /// </summary>
        public static (List<Customer> list, Exception exception) GetCustomersSafe()
        {
            return JsonHelpers.JsonToList<Customer>("Customers.json");

        }
        public static List<Person> GetStudents()
        {
            var (customers, _) = JsonHelpers.JsonToList<Person>("Students.json");
            return customers;
        }
    }
}
