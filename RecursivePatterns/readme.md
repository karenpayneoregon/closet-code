# About

Using Manager and Employee classes which inherit from a person class provides codes samples for.

- [Pattern Matching](https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching)
- [is type pattern expression](https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching#the-is-type-pattern-expression)
- [pattern matching switch statements/expressions](https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching#using-pattern-matching-switch-statements)
- [Recursive Patterns](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/patterns) (some are C#8 and others C#9)
- [Microsoft docs switch (C#8)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)

> The pattern matching features in C# provide syntax to express your algorithms. You can use these techniques to implement the behavior in your classes. You can combine object-oriented class design with a data-oriented implementation to provide concise code while modeling real-world objects.

**From Microsoft**

---

### Peek at code

#### Example 1
```csharp
namespace RecursivePatterns.Classes
{
    public class Helpers
    {
        public static IEnumerable<List<Employee>> GetEmployeesWhereManagerHasThreeYearsAsManager(List<Person> people)
        {
            const int years = 3;

            foreach (var person in people)
            {
                if (person is Manager { YearsAsManager: years, Employees: { } employees })
                {
                    yield return employees;
                }
            }
        }
    }
}
```

#### Example 2

```csharp
namespace RecursivePatterns.Classes
{
    /// <summary>
    /// C#9
    /// </summary>
    public static class LanguageExtensions
    {
        public static List<Employee> GetEmployeesWhereManagerHasYearsAsManager(this Person person) => person switch
        {
            Manager { YearsAsManager: >=4 } manager => manager.Employees,
            Manager { YearsAsManager: 3 } manager => manager.Employees,
            _ => null
        };

    }
}
```

#### Example 3

Conventional switch vs expression switch

```csharp
public static void WriteConventional(Exception exception, ExceptionLogType exceptionLogType = ExceptionLogType.General)
{
    var fileName = "";

    switch (exceptionLogType)
    {
        case ExceptionLogType.Post:
            fileName = "PostUnhandledException.txt";
            break;
        case ExceptionLogType.General:
            fileName = "GeneralUnhandledException.txt";
            break;
        case ExceptionLogType.Data:
            fileName = "DataUnhandledException.txt";
            break;
        case ExceptionLogType.Unknown:
            fileName = "UnknownUnhandledException.txt";
            break;
        default: throw new NotImplementedException();
    }


    Debug.WriteLine($"Conventional: {fileName}");

}
public static void WriteByExpression(Exception exception, ExceptionLogType exceptionLogType = ExceptionLogType.General)
{
    var fileName = exceptionLogType switch
    {
        ExceptionLogType.General => "GeneralUnhandledException.txt",
        ExceptionLogType.Data => "DataUnhandledException.txt",
        ExceptionLogType.Unknown => "UnknownUnhandledException.txt",
        ExceptionLogType.Post => "PostUnhandledException.txt",
        _ => throw new NotImplementedException()
    };

    Debug.WriteLine($"C# 8: {fileName}");

}
```

# See also

- [Building C# 8.0](https://devblogs.microsoft.com/dotnet/building-c-8-0/) by Mads Torgersen, Design Lead for C#
