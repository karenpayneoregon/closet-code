using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
