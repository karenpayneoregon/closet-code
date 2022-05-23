using System;

namespace NorthWind2020Library.Models
{
    /// <summary>
    /// Container for exporting <see cref="Customers"/>
    /// </summary>
    public class CustomersForExcel
    {
        public string CompanyName { get; }
        public string Country { get; }
        public string Title { get; }
        public string Contact { get; }
        public string Phone { get; }
        public DateTime Modified { get; set; }
        public override string ToString() => CompanyName;

        public CustomersForExcel(string companyName, string country, string title, string contact, string phone, DateTime? modifiedDateTime)
        {
            CompanyName = companyName;
            Country = country;
            Title = title;
            Contact = contact;
            Phone = phone;
            if (modifiedDateTime != null) Modified = modifiedDateTime.Value;
        }
    }
}