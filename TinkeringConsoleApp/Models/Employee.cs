using TinkeringConsoleApp.Interfaces;

namespace TinkeringConsoleApp.Models
{
    public class Employee : IEmployee
    {
        public int Identifier { get; set; }
        public int Id => Identifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}