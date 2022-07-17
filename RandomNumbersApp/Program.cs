using System;
using System.Linq;
using RandomNumbersApp.Classes;
using Spectre.Console;

namespace RandomNumbersApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[cyan]Random doubles[/]");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"{NumberHelpers.GetRandomDouble(1, 200),9:F2}");
            }

            AnsiConsole.MarkupLine("[cyan]Random integers[/]");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"{NumberHelpers.GetRandomInt(1, 200),6}");
            }

            AnsiConsole.MarkupLine("[cyan]Press a key to close[/]");
            Console.ReadLine();
        }
    }
}
