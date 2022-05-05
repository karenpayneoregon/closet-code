# About

This code sample shows how to use data annotations without [[EmailAddress]](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.emailaddressattribute?view=net-6.0) used on a string property for Email.

Simple example

```csharp
var humans = Mocked.Humans;

var results = humans
    .Select(human => new EmailItem(human, ValidEmail(human.Email))).ToList();

foreach (var result in results)
{
    Console.WriteLine($"{result.Human.Name,-15}{result.IsValid}");
}
```

Here we simply pass the string which may represent an email to `EmailAddressAttribute' and run `IsValid` which returns true if the email is valid and false if the email is not valid.

```csharp
public class Annotate
{
    public static bool ValidEmail(string emailAddress) 
        => new EmailAddressAttribute().IsValid(emailAddress);
}
```