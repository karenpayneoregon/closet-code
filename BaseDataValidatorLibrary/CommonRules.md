# Rules included

Some of the classes are duplicates of classes in the .NET Framework, there are cases where we need to have more control so create custom by inheriting from [ValidationAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute?view=net-5.0) or [RequiredAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.requiredattribute?view=net-5.0).

| Attribute        |   Description    | Notes |
|:------------- |:-------------|
| CheckPhoneValidationAttribute | Specifies that a data field value is a well-formed phone number. | There is also [PhoneAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.phoneattribute?view=net-5.0) |
| EqualToAttribute | Validates that the property has the same value as the given 'otherProperty'  | There is also [CompareAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.compareattribute?view=net-5.0) |
| ListHasElements | Use to validate a property of type `List` has at least one element  |  |
| MyStringLengthAttribute | Duplicates StringLength | Basically shows that if StringLength does not suit requirements write your own  |
| RequiredEnumAttribute | Validates a property of type Enum is assigned |  |
| SocialSecurityAttribute | Simple SSN validation | See also [1] |
| ValidateYearsAttribute | Validate a date is in a specific year range  |  |



## Additional methods for SSN validation

```csharp
public static class ValidatingHelpers
{
    public static bool IsSSNValid(this string ssn) 
        => new Regex(@"^(?!\b(\d)\1+-(\d)\1+-(\d)\1+\b)(?!123-45-6789|219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}-(?!00)\d{2}-(?!0{4})\d{4}$").IsMatch(ssn);
}
```

Or

```csharp
[RegularExpression("^\\d{9}|\\d{3}-\\d{2}-\\d{4}$", ErrorMessage = "Invalid Social Security Number")]
[Required(ErrorMessage = "Contact {0} is required"), DataType(DataType.Text)]
public string SSN { get; set; }
```


