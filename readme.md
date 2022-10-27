
![image](assets/header.png)

# About

This repository is home to `useful` and `obscure` code samples.

For example using a range in a foreach

```csharp
foreach (var index in 1..3)
{
    Debug.WriteLine($"{owners[index], -4} owns a {pets[index]}");
}
```

Or a complete enum value converter in EF Core

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder
        .Entity<Book>()
        .Property(e => e.BookVariantId)
        .HasConversion<int>();

    modelBuilder
        .Entity<BookVariant>()
        .Property(e => e.BookVariantId)
        .HasConversion<int>();

    modelBuilder
        .Entity<BookVariant>().HasData(
            Enum.GetValues(typeof(BookVariantId))
                .Cast<BookVariantId>()
                .Select(e => new BookVariant()
                {
                    BookVariantId = e,
                    Name = e.ToString()
                })
        );
}
```

Or perhaps home-brewed data annotations

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class YearRangeAttribute : ValidationAttribute
{
    public YearRangeAttribute(int maximumYear)
    {
        MaximumYear = maximumYear;
    }
    /// <summary>
    /// Maximum permitted year
    /// </summary>
    public int MaximumYear { get; }
    /// <summary>
    /// Minimum permitted year
    /// </summary>
    public int MinimumYear { get; set; }
    public override string FormatErrorMessage(string name)
    {
        if (ErrorMessage is null && ErrorMessageResourceName is null)
        {
            ErrorMessage = "'Year {0}' and/or year '{1}' are invalid";
        }

        return $"{name} year must be between {MinimumYear} and {MaximumYear}";

    }

    public override bool IsValid(object sender)
        => ((DateTime)sender).Year.Between(MinimumYear, MaximumYear);
}
```

In regards to obscure, this means fringe case code that is seldom needed but when needed woohoo.

In some instances, code to use will be in one project, other times placed into class projects and when code is separated the markdown files will indicate this.

**Notes**

This line indicates that the namespace does not match it's location and should not even if not using `Resharper`.

```csharp
// ReSharper disable once CheckNamespace - do not change
```

**Windows forms**

Some examples are windows form specific while others simply can be understood better in a form rather than a console or test project.

## .NET Frameworks

The majority of code has been done using .NET Core 5 while a handful use .NET Framework 4.8

# Links

- .NET Source Generators: Finding Class Declarations [![](assets/Link_16x.png)](https://khalidabuhakmeh.com/dotnet-source-generators-finding-class-declarations)

# Credits

- In some cases code samples are from Stackoverflow questions were I've written out the solution or taken someone elses solution.
- Other code samples are from [Khalid Abuhakmeh](https://khalidabuhakmeh.com/about)
- 98 percent of code presented have been written by Karen Payne.

# Projects

Many use `.NET Core 5` which is out of support. If are using `.NET Core 6` or higher, alter the project file to

```xml
<PropertyGroup>
   <OutputType>Exe</OutputType>
   <TargetFramework>net6.0</TargetFramework>
   <ImplicitUsings>enable</ImplicitUsings>
   <Nullable>enable</Nullable>
</PropertyGroup>
```

---

| Name        |   Description    |   Framework |
|:------------- |:-------------|:-------------|
| BooksConsoleApp | Example for EF Core `HasConversion` for `enum` | .NET Core 5 - console |
| DiagnosticListeners | EF Core diagnotic listners  | .NET Core 5 - console |
| HasConversion | Partial EF Core `HasConversion` | .NET Core 5 - console |
| NorthWind2020ConsoleApp | EF Core self-referencing table | .NET Core 5 - console |
| OwnedEntities | EF Core owned entities | .NET Core 5 - console |
| MsBuildCompressSolution | `BeforeTargets` create zip file | .NET Core 5 - console |
| MsBuildMakeDirectory | After build create directory | .NET Core 5 - console |
| **Spectre.Console** |  |  |
| AskConsoleApp :heavy_check_mark: | Example to accept string, and dates followed by prompting for multiple choices | .NET Core 5 - console |
| AskConsoleApp2 | Prompt for number in range, multiple choices | .NET Core 5 - console |
| CenterConsoleWindowSimple :heavy_check_mark: | Center a console window | .NET Core 5 - console |
| LoginConsoleApp | Console hidden password input example | .NET Core 5 - console |
| MenuConsoleApp  :heavy_check_mark: | Console app,create menu with data from a database | .NET Core 5 - console |
| MenuConsoleAppBasic :heavy_check_mark: | Console app menu, basic is opininated | .NET Core 5 - console |
| MenuSimpleApp | Another take on a console app menu | .NET Core 5 - console |
|  |  |  |
| ActionChaining | Chaining actions and delegates | .NET Core 5 - console |
| ArrayNoDuplicates | Prevent duplicates in array | .NET Core 5 - console |
| BetweenCodeSample :heavy_check_mark: | Generic extensions for IComparable | .NET Core 5 - console |
| BindingListAddRangeApp | `AddRange` from the project [BindingListLibrary](https://github.com/karenpayneoregon/closet-code/tree/master/BindingListLibrary) | .NET Core 5 - console |
| BooleanLanguageExtensions | Code sample to translate true/false to spoken word in various languages. | .NET Core 5 - console  |
| CalculateExpirationApp | DaysToExpiration method to calculate diff in two dates with days, hours, minutes and seconds | .NET Core 5 - console |
| CalculatePersonAges | NuGet package [PayneAgeCalculator](https://www.nuget.org/packages/PayneAgeCalculator/) example to calc a person age |  |
| CharacterOccurrencesConsoleApp | Example to obtain character count for each character in a string | .NET Core 5 - console |
| CreateRandomListConsoleApp | Create random dates and int | .NET Core 5 - console |
| DateTimeAmPm | Given a `DateTime` with either `a.m.` or `p.m.` and properly get the value (oddball forum question) | .NET Core 5 - console |
| DecimalFun | Unsual decimal extensions `GetFraction` `CountDecimalPlaces` | .NET Core 5 - console |
| DiacriticsConsoleApp | Diacritics converters | .NET Core 5 - console |
| ElapsedTime | Code sample to format TimeSpan for elapsed time. | .NET Core 5 - console |
| EnhancedPatternMatching | starter for pattern matching [Helpers](https://github.com/karenpayneoregon/closet-code/blob/master/EnhancedPatternMatching/LanguageExtensions/Helpers.cs) [TimeOfDay](https://github.com/karenpayneoregon/closet-code/blob/master/EnhancedPatternMatching/Howdy.cs) | .NET Core 5 - console |
| ExamplePatternMatching | pattern matching with `when` | .NET Core 5 - console  |
| ExcelToAndFromOADate | `DateTime.FromOADate` and `ToOADate` examples | .NET Core 5 - console |
| ExceptionsWhenApp :heavy_check_mark: | Samples for try/catch/when | .NET Core 5 - console |
| FileNamesExamples :heavy_check_mark: | Code to create file names incrementally `Log_1.txt` `Log_2.txt` `Log_3.txt` `Log_4.txt` | .NET Core 5 - console  |
| GetControlFormProject | Shows how to iterate controls on a form with various recursive extension methods | .NET Core 5 WinForms |
| GetInformationForModel | Partly generic code to iterate an instance of a model/class | .NET Core 5 - console |
| GetLastNumberInString :heavy_check_mark: | code to the last number in a string in the format of `some chars-a number` e.g. `ABC-09` | .NET Core 5 - console  |
| GroupByMultiplePropertiesFindDuplicates | Simple `groupby` on several properties of a class to get distinct instances then place into a new list. | .NET Core 5 - console |
| IFormatProviderExample | Simple example for `IFormatProvider` which should not be used in a production | .NET Core 5 - console |
| IncrementSequenceConsole | increment an alpha-numeric value | .NET Core 5 - console |
| IncrementSequenceDemos | Continuation of `IncrementSequenceConsole` |  .NET Core 6 - console |
| IndicesRanges :heavy_check_mark: | Using month names, provides a basic understanding of working with indices e.g. `CurrentInfo.MonthNames[..^1]`  | .NET Core 5 - console |
| InterfacesUsingAnimals :heavy_check_mark: | basic example for using `interfaces` | .NET Core 6 - console |
| IsYouCodeReadable | talk with code samples on code readability | .NET Core 5 - console  |
| LoopThroughFile | loop through file with exception handling | .NET Core 5 - console |
| MarkOfTheWeb | A utility to remove `mark of the web` from a folder recursively to all sub-folders. see NuGet [package](https://www.nuget.org/packages/MarkOfTheWeb/) | .NET Core 5 - console |
| MonthNamesDifferentLanguages | Display month names in several languages. | .NET Core 5 - console |
| NullCoalescingOperatorApp | simple usage `??`  | .NET Core 5 - console |
|  QueryHelpersConsoleApp | Basic samples for [QueryHelpers.AddQueryString](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.webutilities.queryhelpers.addquerystring?view=aspnetcore-6.0) | .NET Core 5 - console |
| RandomNumbersApp | Show how to get random double and random int between min and max values. For double there is truncation to two for the fraction part | .NET Core 5 - console |
| RangeForEach | `foreach (var index in 1..3)` | .NET Core 5 - console |
| SimpleEmailValidationDataAnnotations | This code sample shows how to use data annotations without [[EmailAddress]](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.emailaddressattribute?view=net-6.0) used on a string property for Email. | .NET Core 5 - console |
| SingletonSimple | Simple [Singleton](https://csharpindepth.com/articles/singleton) example. | .NET Core 5 - console |
| SwitchExpressions | Ongoing switch expression samples | .NET Core 5 - console |
| TinkeringConsoleApp | Code samples for finding missing int values in arrays. | .NET Core 5 - console |
| TransformingConsoleCodeSample | Generic transformer which at the core uses `Array.ConvertAll`. | .NET Core 6 - console |
|  TryGetNonEnumeratedCountConsoleApp | [TryGetNonEnumeratedCount](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.trygetnonenumeratedcount?view=net-7.0) |   .NET Core 6 - console |
|  |  |  |
|  |  |  |
|  |  |  |

:heavy_check_mark: Useful any time

:balance_scale: With little effort `.NET Core 5` code can be used for `.NET Core 6` and higher


# Great Visual Studio extensions

- [ReSharper](https://marketplace.visualstudio.com/items?itemName=JetBrains.ReSharper) The legendary .NET productivity tool: find and fix errors and code smells; navigate and refactor; run unit tests and write quality code faster.
- [EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools) Useful design-time DbContext features, added to the Visual Studio Solution Explorer context menu.
- [Sql Tools](https://marketplace.visualstudio.com/items?itemName=Mojtabakaviani.SqlTools&ssr=false#overview) SQL syntax highlighting and completion (keywords, operators, functions and variables) to string literals