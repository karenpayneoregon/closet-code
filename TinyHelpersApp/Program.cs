using TinyHelpersApp.Classes;

namespace TinyHelpersApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[yellow]Hello[/]");
            var people = GetPeople();

            foreach (var (person, index) in people.WithIndex())
            {
                AnsiConsole.MarkupLine($"[cyan]{index,-5}[/]{person.FirstName}");
            }
            Console.ReadLine();
        }
    }
}