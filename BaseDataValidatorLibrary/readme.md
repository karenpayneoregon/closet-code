# About

Provides methods for validating models using data annotations.

## Simple example

```csharp
public class Person
{
    public int Id { get; set; }
    [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
    [Required(ErrorMessage = "{0} Required")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
    public string FirstName { get; set; }

    [RegularExpression("^.{3,}$", ErrorMessage = "{0} Minimum 3 characters required")]
    [Required(ErrorMessage = "{0} Required")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid {0}")]
    public string LastName { get; set; }

    [ValidateYears(ErrorMessage = "Valid range for BirthDate is {0} and {1}")]
    public DateTime BirthDate { get; set; }
}
```
</br>

**Rules**

1. FirstName and LastName must has a least three characters using standard annotations `RegularExpression`, `Required` and `StringLength`
2. BirthDate uses a user define `ValidationAttribute` shown below which has a range, minus 90 years from today to today.

```csharp
/// <summary>
/// Validate year only
/// </summary>
public class ValidateYearsAttribute : ValidationAttribute
{
    private readonly DateTime _minValue = DateTime.UtcNow.AddYears(-90);
    private readonly DateTime _maxValue = DateTime.UtcNow;

    public override bool IsValid(object sender)
    {
        DateTime value = (DateTime)sender;
        return value.Year >= _minValue.Year && value.Year <= _maxValue.Year;
    }

    public override string FormatErrorMessage(string name)
    {
        return string.Format(ErrorMessage!, 
            _minValue.ToString("yyyy"), 
            _maxValue.ToString("yyyy"));
    }
}
```

**Validating unit test**

1. First test is a positive test
2. Second test validates `ValidateYearsAttribute` works correctly
 

```csharp
using System;
using BaseDataValidatorLibrary.Helpers;
using BaseModelsLibrary.Models;
using NetCoreUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using static System.DateTime;

namespace NetCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class PersonTests : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void ValidPerson()
        {

            // arrange
            Person person = new ()
            {
                FirstName = "Mike",
                LastName = "Flowers",
                BirthDate = new DateTime(1932, Now.Month, Now.Day)
            };

            // act
            EntityValidationResult result = Model.Validate(person);

            // assert
            Check.That(result.IsValid).IsTrue();
        }

        [TestMethod]
        [TestTraits(Trait.Annotations)]
        public void InvalidDateValidPerson()
        {
            // arrange
            Person person = new ()
            {
                FirstName = "Mike",
                LastName = "Flowers",
                BirthDate = new DateTime(1931, Now.Month, Now.Day)
            };

            // act
            EntityValidationResult result = Model.Validate(person);

            // assert
            Check.That(result.IsValid).IsFalse();

        }
    }

}
```

We validate with the following and since `Validate` is generic it works on any model/class.

```csharp
EntityValidationResult result = Model.Validate(person);
```

And check with

```csharp
result.IsValid
```





