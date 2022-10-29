using RandomNumbersApp.Classes;
using Spectre.Console;
using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace RandomNumbersApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        private static void Examples()
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
        }
    }
}





