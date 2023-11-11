using TwitterQuestions.Classes;

namespace TwitterQuestions;

internal partial class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]Hello[/]");
        Console.ReadLine();
    }

    private static void Example1(DateOnly date)
    {
        var (day, month, year) = date;
    }
    private static void Example2(DateOnly date)
    {
        var day = date.Day;
        var month = date.Month;
        var year = date.Year;
    }
}