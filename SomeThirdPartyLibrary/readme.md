# About

This class project represents a fictitious company library which is sealed, no partial classes or source code.

Is used in `DeconstructorCodeSamples` project to create a `Deconstruct` language exension method.

```csharp
public static class ThirdPartyExtensions
{
    public static void Deconstruct(
        this Customer customer, 
        out int id, 
        out string companyName, 
        out int? contactIdentifier, 
        out int? countryIdentifier)
    {
        id = customer.CustomerIdentifier;
        companyName = customer.CompanyName;
        contactIdentifier = customer.ContactId;
        countryIdentifier = customer.CountryIdentifier;
    }
}
```