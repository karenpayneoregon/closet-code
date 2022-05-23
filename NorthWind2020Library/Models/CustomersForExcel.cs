namespace NorthWind2020Library.Models
{
    public class CustomersForExcel
    {
        public string CompanyName { get; }
        public string Country { get; }
        public string Title { get; }
        public string Contact { get; }
        public string Phone { get; }

        public CustomersForExcel(string companyName, string country, string title, string contact, string phone)
        {
            CompanyName = companyName;
            Country = country;
            Title = title;
            Contact = contact;
            Phone = phone;
        }
    }
}