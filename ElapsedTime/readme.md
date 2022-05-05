# About

Code sample to format TimeSpan for elapsed time.

```csharp
public static string FormatElapsed(this TimeSpan span) => span.Days switch
{
    > 0 => $"{span.Days} days, {span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds",
    _ => span.Hours switch
    {
        > 0 => $"{span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds",
        _ => span.Minutes switch
        {
            > 0 => $"{span.Minutes} minutes, {span.Seconds} seconds",
            _ => span.Seconds switch
            {
                > 0 => $"{span.Seconds} seconds",
                _ => ""
            }
        }
    }
};
```

**Example**

```csharp
static void Main(string[] args)
{
    var startDate = DateTime.Now.AddHours(-12).AddMinutes(1).AddSeconds(-20);
    var endDate = DateTime.Now;

    Console.WriteLine($"Result: {(endDate - startDate).FormatElapsed()}");

    Console.ReadLine();
}
```