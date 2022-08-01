using System.Collections.Generic;
using TinkeringConsoleApp.Interfaces;

namespace TinkeringConsoleApp.Models
{
    public class Manager : IEmployee
    {
        public int Identifier { get; set; }
        public int Id => Identifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Employees { get; set; }
    }
}