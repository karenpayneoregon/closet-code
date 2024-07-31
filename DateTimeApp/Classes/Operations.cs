using System.Globalization;
using System.Text.RegularExpressions;

namespace DateTimeApp.Classes;

public static class Operations
{
    public static void NoDefaultToCurrentDateTime()
    {
        var cultureInfo = new CultureInfo("en");
        string dateString = "26 November 2022";
        var dateTime = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
        AnsiConsole.MarkupLine($"[cyan]{dateTime}[/]");
    }

    public static void Example1()
    {
        
        string[] format = { "dd-MM-yyyy HH:mm:ss" };
        
        string value = "26-10-2022 15:30:20";

        //Check if string is a valid date by converting using DateTime.TryParseExact
        if (DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out var datetime))
        {
            Console.WriteLine("Valid  Date: " + datetime);
        }
        else
        {
            Console.WriteLine("Invalid Date");
        }
    }

    /// <summary>
    /// https://stackoverflow.com/a/74749392/5509738
    /// </summary>
    public static void Example2()
    {
        foreach (var date in ParseDates("07th December 2022 08 December 2022 01st December 2022"))
        {
            Console.WriteLine(date.ToShortDateString());
        }
    }

    public const string Pattern = @"(?<day>\d{1,2})((st)|(nd)|(rd)|(th))? (?<month>[A-Za-z]+) (?<year>\d{4})";
    public static Regex DateRegex = new Regex(Pattern);
    public static IEnumerable<DateTime> ParseDates(string input)
    {
        var matches = DateRegex.Matches(input);
        var result = new List<DateTime>();
        var culture = new CultureInfo("en-US");

        foreach (var match in matches.Cast<Match>())
        {
            var day = match.Groups["day"].ToString();
            var month = match.Groups["month"].ToString();
            var year = match.Groups["year"].ToString();
            var date = DateTime.ParseExact($"{day}-{month}-{year}", "d-MMMM-yyyy", culture);

            result.Add(date);
        }

        return result;
    }
}