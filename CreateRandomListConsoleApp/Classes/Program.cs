using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CommonLibrary.Classes;
using CommonLibrary.LanguageExtensions;
using CreateRandomListConsoleApp.Classes;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace CreateRandomListConsoleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        private static void RandomDates()
        {
            AnsiConsole.MarkupLine("[yellow]Dates[/]");
            var dates = MockedData.DateTimeList;
            var randomDates = dates.Shuffle(3);
            foreach (var dateTime in randomDates)
            {
                AnsiConsole.MarkupLine($"{dateTime.Month}/{dateTime.Day}/[cyan]{dateTime.Year}[/]");
            }
        }

        private static void RandomIntegers()
        {
            AnsiConsole.MarkupLine("[yellow]Int[/]");
            var list = MockedData.IntegerList();
            var randomIntegers = list.Shuffle().Take(3);

            foreach (var integer in randomIntegers)
            {
                AnsiConsole.MarkupLine(string.Join(",", randomIntegers).Replace(",", "[white],[/]"));
            }
        }
    }
}





