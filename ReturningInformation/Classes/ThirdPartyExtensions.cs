using SomeThirdPartyLibrary.Classes;

namespace ReturningInformation.Classes
{
    public static class ThirdPartyExtensions
    {
        public static void Deconstruct(this Customer customer, out int id,  out string companyName)
        {
            id = customer.CustomerIdentifier;
            companyName = customer.CompanyName;
        }

        public static void Deconstruct(this Customer customer, out int id, out string companyName, out int? contactIdentifier, out int? countryIdentifier)
        {
            id = customer.CustomerIdentifier;
            companyName = customer.CompanyName;
            contactIdentifier = customer.ContactId;
            countryIdentifier = customer.CountryIdentifier;
        }

        public static void Deconstruct(this Customer customer, out int id, out string street, out string city, out string postalCode, out int? countryCode)
        {
            id = customer.CustomerIdentifier;
            street = customer.Street;
            city = customer.City;
            postalCode = customer.PostalCode;
            countryCode = customer.CountryIdentifier;
        }
    }
}
