using System.Globalization;

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
}