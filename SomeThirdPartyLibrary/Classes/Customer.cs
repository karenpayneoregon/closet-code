﻿
namespace SomeThirdPartyLibrary.Classes
{
    public class Customer
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public int? ContactId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int? CountryIdentifier { get; set; }
        public override string ToString() => CompanyName;
    }
}
