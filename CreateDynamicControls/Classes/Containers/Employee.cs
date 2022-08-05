using System;

namespace CreateDynamicControls.Classes.Containers
{
    public class Employee
    {
        public int Id { get; set; }

        public string TitleOfCourtesy { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";

    }
}
