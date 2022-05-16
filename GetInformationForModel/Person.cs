using System;
using System.Collections.Generic;

namespace GetInformationForModel
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> List { get; set; }

        public Person()
        {
            List = new List<string> { "One", "Two", "Three" };
        }
    }
}