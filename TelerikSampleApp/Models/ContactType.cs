using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            Contacts = new HashSet<Contact>();
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
        }

        public int ContactTypeIdentifier { get; set; }
        public string ContactTitle { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
