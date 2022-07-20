using System;

namespace DataGridViewExportTextFile.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(int identifier)
        {
            Id = identifier;
        }
    }
}