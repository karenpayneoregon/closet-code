using System;


namespace ReturningInformation.Models
{
    public partial class Person
    {
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        
        public override string ToString() => $"{PersonID,-5:D3}{FirstName, -12}{LastName, -12}{HireDate:d}";

    }


}
