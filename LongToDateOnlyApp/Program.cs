namespace LongToDateOnlyApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]Long as string to DateOnly[/]");
        List<string> list = new()
        {
            "1640908800000", "1648684800000",
            "1656547200000", "1664496000000"
        };


        foreach (var value in list)
        {
            var dateOnly = DateOnly.FromDateTime(DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(value)).Date);
            Console.WriteLine(dateOnly);
            DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(value));
            Console.WriteLine(dateTime);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}