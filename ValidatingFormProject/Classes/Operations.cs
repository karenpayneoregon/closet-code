using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Bogus;
using Country = ValidatingFormProject.Models.Country;
using Customer = ValidatingFormProject.Models.Customer;

namespace ValidatingFormProject.Classes
{
    public class Operations
    {
        public static List<Country> Countries()
        {
            var list = JsonSerializer.Deserialize<List<Country>>(
                File.ReadAllText(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Countries.json")));

            list!.Insert(0, new Country() { CountryIdentifier = -1, CountryName = "Select" });

            return list;
        }

        /// <summary>
        /// Permits starting with a valid customer
        /// </summary>
        public static List<Customer> Customers => new()
        {
            new Customer()
            {
                FirstName = "Karen",
                LastName = "Payne",
                PostalCode = "97223",
                Email = "someEmail@comcast.net",
                SocialSecurity = "205-16-7777",
                BirthDate = new DateTime(1945, 1, 1),
                Pin = "2222",
                CreditCardNumber = "5503022366657760",
                NotesList = new List<string>() {"","", "", ""},
                Country = new Country()
                {
                    CountryIdentifier = 9,
                    CountryName = "Germany"
                },
                AppointmentDate = new DateTime(2022, 5, 5)
            }
        };

        public static List<string> CreditCardNumbersValid => new()
        {
            "371144371144376",
            "341134113411347",
            "370000000000002",
            "378282246310005",
            "6011016011016011",
            "6559906559906557",
            "6011000000000012",
            "6011111111111117",
            "5111005111051128",
            "5112345112345114",
            "5424000000000015",
            "5105105105105100",
            "4112344112344113",
            "4007000000027",
            "4111111111111111",
            "4110144110144115",
            "4114360123456785",
            "4061724061724061",
            "5115915115915118",
            "5116601234567894",
            "36111111111111",
            "36110361103612",
            "36438936438936",
            "30569309025904",
        };

        public static void UpdateCustomer(Customer customer)
        {
            // TODO - update to a file or database or send to a service and post
        }

        public static List<string> CreateNotes(int count = 3)
        {
            List<string> list = new ();
            if (count == 0)
            {
                return list;
            }
            else
            {
                Enumerable.Range(1, count).ToList().ForEach(x => list.Add(new Faker().Lorem.Sentences(1)));
                return list;
            }
        }
    }
}
