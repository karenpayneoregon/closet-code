using System.Runtime.CompilerServices;
using TinyHelpersApp.Classes;

// ReSharper disable once CheckNamespace
namespace TinyHelpersApp
{
    internal partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            AnsiConsole.MarkupLine("");
            Console.Title = "Code sample";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }

        static IEnumerable<Person> GetPeople() =>
            new List<Person> { 
                new() { FirstName = "Donald", LastName = "Duck" },
                new() { FirstName = "Mickey", LastName = "Mouse" },
                new() { FirstName = "Daisy", LastName = "Duck" }
            };
    }
}
