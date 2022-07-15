using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using BetweenCodeSample.Extensions;
using CoreExtensions.LanguageExtensions;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

namespace BetweenCodeSample
{
    /// <summary>
    /// Example for a generic language extension for <see cref="IComparable"/>
    /// In this case the extension is used for int and DateTime
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            IComparableExtensionExamples();
            SwitchExpression();
            BetweenTwoItemsInStringList();
            BetweenTwoItemsInIntList();
            Console.ReadLine();
        }



        /// <summary>
        /// Example of using a switch expression on int
        /// </summary>
        private static void SwitchExpression()
        {
            AnsiConsole.MarkupLine($"[yellow]{nameof(SwitchExpression)}[/]");
            Console.WriteLine($"\t{7.CaseWhen()}");
            Console.WriteLine($"\t{5.CaseWhen()}");
            Console.WriteLine($"\t{1.CaseWhen()}");
            Console.WriteLine($"\t{16.CaseWhen()}");

            Console.WriteLine();
        }

        /// <summary>
        /// Example using a generic extension method on int and date time
        /// </summary>
        private static void IComparableExtensionExamples()
        {

            AnsiConsole.MarkupLine($"[yellow]{nameof(IComparableExtensionExamples)}[/]");
            AnsiConsole.MarkupLine("Working with [b]int[/]");
            int age = 29;

            Console.WriteLine($"\t{age,-3} is over 30 {age.Between(30, 30).ToYesNo()}");

            age = 30;
            Console.WriteLine($"\t{age,-3} is over 30 {age.Between(30, 30).ToYesNo()}");

            age = 30;
            Console.WriteLine($"\t{age,-3} is between 19 and 30 {age.Between(19, 30).ToYesNo()}");

            age = 12;
            Console.WriteLine($"\tis child {age.IsChild().ToYesNo()}");

            Console.WriteLine($"\t30.IsOver30() {30.IsOver30()}");
            Console.WriteLine($"\t31.IsOver30() {31.IsOver30()}");

            AnsiConsole.MarkupLine("Working with [b]DateTime[/]");
            DateTime lowDateTime = new(2022, 1, 1);
            DateTime someDateTime = new(2022, 1, 2);
            DateTime highDateTime = new(2022, 1, 8);

            Console.WriteLine($"\t{someDateTime:d} between {lowDateTime:d} and {highDateTime:d}? {someDateTime.Between(lowDateTime, highDateTime).ToYesNo()}");

            someDateTime = new DateTime(2022, 2, 2);
            Console.WriteLine($"\t{someDateTime:d} between {lowDateTime:d} and {highDateTime:d}? {someDateTime.Between(lowDateTime, highDateTime).ToYesNo()}");

        }

        /// <summary>
        /// Get inclusive list between two elements in a list of string
        /// </summary>
        private static void BetweenTwoItemsInStringList()
        {
            AnsiConsole.MarkupLine($"[yellow]{nameof(BetweenTwoItemsInStringList)}[/]");
            var months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();
            var result = months.BetweenElements("March", "September");
            Console.WriteLine($"\t{string.Join(",", result)}");
        }

        /// <summary>
        /// Get inclusive list between two elements in a list of int
        /// </summary>
        private static void BetweenTwoItemsInIntList()
        {
            AnsiConsole.MarkupLine($"[yellow]{nameof(BetweenTwoItemsInIntList)}[/]");
            var values = Enumerable.Range(1, 20).ToList();
            var result = values.BetweenElements(2, 8);

            Console.WriteLine($"\t{string.Join(",", result)}");
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Between";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }

}
