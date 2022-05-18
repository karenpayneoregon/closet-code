using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class Country
    {
        public Country()
        {
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
            Suppliers = new HashSet<Supplier>();
        }

        public int CountryIdentifier { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
