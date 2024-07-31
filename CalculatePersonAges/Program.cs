using PayneAgeCalculator.Classes;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

namespace CalculatePersonAges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculate age";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
            DateTime birthDate = new DateTime(1956, 9, 24);
            AnsiConsole.MarkupLine($"[cyan]Birth:[/] [b]{birthDate:MM/dd/yyyy}[/] [cyan]age[/] [b]{birthDate.Age().YearsMonthsDays}[/]");
            Console.ReadLine();
        }
    }
}