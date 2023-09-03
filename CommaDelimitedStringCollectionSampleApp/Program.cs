using System.Collections;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CommaDelimitedStringCollectionSampleApp.Classes;

namespace CommaDelimitedStringCollectionSampleApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        {
            AnsiConsole.MarkupLine("[yellow]Comma delimited full month names[/]");
            CommaDelimitedStringCollection result = new();

            result.AddRange(DateTimeFormatInfo.CurrentInfo.MonthNames[..^1]);
            Console.WriteLine($"\t{result}");

            AnsiConsole.MarkupLine("[yellow]Remove current month[/]");
            var currentMonthName = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);
            result.Remove(currentMonthName);
            Console.WriteLine($"\t{result}");

            AnsiConsole.MarkupLine("[yellow]Insert current month at proper index[/]");
            result.Insert(DateTime.Now.Month - 1, currentMonthName);
            Console.WriteLine($"\t{result}");
        }

        Console.WriteLine();

        {
            AnsiConsole.MarkupLine("[yellow]Comma delimited abbreviated month names[/]");
            CommaDelimitedStringCollection result = new();
            result.AddRange(DateTimeFormatInfo.CurrentInfo.AbbreviatedMonthNames[..^1]);
            Console.WriteLine($"\t{result}");

            for (int index = 0; index < result.Count; index++)
            {
                Console.WriteLine($"\t{result[index]}");
            }
        }

        {
            AnsiConsole.MarkupLine("[yellow]Using an int array[/]");
            int[] items = { 1, 2, 3 };
            CommaDelimitedStringCollection result = new();
            result.AddRange(items.ToStringArray());
            result.Add("4");
            Console.WriteLine($"\t{result}");
            AnsiConsole.MarkupLine($"\tIs [white on red]3[/] in collection {result.Contains("3").ToYesNo()}");
        }

        {
            AnsiConsole.MarkupLine("[yellow]Files found[/]");
            CommaDelimitedStringCollection result = new();
            var files = FileHelpers.FilterFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory), "txt", "json");
            foreach (var file in files)
            {
                result.Add(Path.GetFileName(file));
            }
            Console.WriteLine($"\t{result}");
            Console.WriteLine(result.Contains("appsettings.json").ToYesNo());

result.SetReadOnly();
if (!result.IsReadOnly)
{
    result.Add("SomeFile.txt");
}
        }



        Console.ReadLine();
    }


}