namespace ExcelToAndFromOADate
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[yellow]To and From [/][cyan]OADate[/]");
            var result = DateTime.Now.ToOADate();
            Console.WriteLine(result);
            Console.WriteLine(DateTime.FromOADate(result));
            Console.ReadLine();
        }
    }
}