# About

Display month names in several languages.

```csharp
public class Operations 
{
    public static List<string> EnglishMonthList
        => Enumerable.Range(1, 12).Select((index) =>
            DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList();

    public static List<string> RussianMonthNames()
        => Enumerable.Range(1, 12).Select((index) =>
            new CultureInfo("ru-RU").DateTimeFormat.GetMonthName(index)).ToList();

    public static List<string> VietnameseMonthNames()
        => Enumerable.Range(1, 12).Select((index) =>
            new CultureInfo("vie").DateTimeFormat.GetMonthName(index)).ToList();

    public static List<string> SpanishMonthNames()
        => Enumerable.Range(1, 12).Select((index) =>
            new CultureInfo("es").DateTimeFormat.GetMonthName(index)).ToList();

    public static List<string> MonthNames(string languageCode)
        => Enumerable.Range(1, 12).Select((index) =>
            new CultureInfo(languageCode).DateTimeFormat.GetMonthName(index)).ToList();
}
```