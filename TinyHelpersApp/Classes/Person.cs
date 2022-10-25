using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyHelpersApp.Classes
{
    public class Person
    {
        //public Person(string firstName, string lastName, string city)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    City = city;
        //}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; }
    }
}
