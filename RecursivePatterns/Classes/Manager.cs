using System.Collections.Generic;

namespace RecursivePatterns.Classes
{
    public class Manager : Person
    {
        public int YearsAsManager { get; set; }
        public List<Employee> Employees { get; set; }
    }
}