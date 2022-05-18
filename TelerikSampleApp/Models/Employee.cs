using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentifier { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }

        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual Country CountryIdentifierNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
