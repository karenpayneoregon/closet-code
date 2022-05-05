using System.Collections.Generic;

namespace MockingPeopleLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
        public List<ContactDevice> ContactDevices { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";

        public Person()
        {
            
        }

        public Person(int id)
        {
            Id = id;
            Addresses = new List<Address>();
            ContactDevices = new List<ContactDevice>();
        }
    }
}