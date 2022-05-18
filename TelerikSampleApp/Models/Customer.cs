using System;
using System.Collections.Generic;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public int? ContactId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentifier { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? ContactTypeIdentifier { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual Country CountryIdentifierNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
