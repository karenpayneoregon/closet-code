using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ContactDevices = new HashSet<ContactDevice>();
            Customers = new HashSet<Customer>();
        }

        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ContactTypeIdentifier { get; set; }

        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual ICollection<ContactDevice> ContactDevices { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
