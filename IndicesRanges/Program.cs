using System;
using System.Collections.Generic;
using System.Linq;
using IndicesRanges.Classes;
using Spectre.Console;
using static System.Globalization.DateTimeFormatInfo;

namespace IndicesRanges
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DoMonths();
            DoStringArray();
            DoIntArray();
            WorkDayNamesIndexing();

            Console.ReadLine();
        }

        /// <summary>
        /// Get first 12 names were ^1 skips the last element
        /// ^ is known as the "Hat" operator
        /// </summary>
        /// <returns></returns>
        public static List<string> MonthNames()
            => CurrentInfo!.MonthNames[..^1].ToList();

        /// <summary>
        /// Convention way to get 12 month names
        /// </summary>
        /// <returns></returns>
        public static List<string> MonthList() 
            => CurrentInfo!.MonthNames.Take(12).ToList();

        public static void DoMonths()
        {

            AnsiConsole.Write(new Rule($"[yellow]Indexing months[/]").LeftAligned().RuleStyle("grey"));

            var m1 = MonthNames();
            var m2 = MonthList();

            for (int index = 0; index < m1.Count; index++)
            {
                Console.WriteLine($"{m1[index],-15}{m2[index]}");
            }

            Console.WriteLine();
            MonthsIndexed();
        }

        private static void MonthsIndexed()
        {
            AnsiConsole.Write(new Rule($"[yellow]{nameof(MonthsIndexed)}[/]").LeftAligned().RuleStyle("grey"));
            var months = CurrentInfo.MonthNames[..^1].ToList();
            for (int index = months.Count; index != 0; index--)
            {
                // index from end
                var currentIndex = new Index(index, true);
                Console.WriteLine($"{currentIndex,-5}{months[currentIndex]}");
            }
        }
        /// <summary>
        /// Get work days via a range using indices
        /// </summary>
        private static void WorkDayNamesIndexing()
        {
            AnsiConsole.Write(new Rule($"[yellow]{nameof(WorkDayNamesIndexing)}[/]").LeftAligned().RuleStyle("grey"));
            var days = CurrentInfo?.DayNames;

            var workDays = days?[1..6];

            // Monday through Friday show day names
            foreach (var day in workDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("");

            // to visualize indices done above e.g. 0 is Sunday
            var indexed = days!
                .Select((name, index) => new
                {
                    Name = name,
                    Index = index
                });

            foreach (var dayItem in indexed)
            {
                Console.WriteLine($"{dayItem.Index +1,-3}{dayItem.Name}");
            }

        }
        private static void DoIntArray()
        {
            AnsiConsole.Write(new Rule($"[yellow]int array indexing[/]").LeftAligned().RuleStyle("grey"));
            int[] numberIntegers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Index index1 = 3;  // number 3 from beginning (zero-based)
            Index index2 = ^4; // number 4 from end ("hat" operator)

            Console.WriteLine($"{numberIntegers[index1]}, {numberIntegers[index2]}"); // "3, 6"


            foreach (var index in numberIntegers[2..5]) // start index is inclusive, end index is exclusive (non-inclusive)!
            {
                Console.Write(index); // 234
            }
        }
        private static void DoStringArray()
        {
            AnsiConsole.Write(new Rule($"[yellow]String array indexing[/]").LeftAligned().RuleStyle("grey"));
            string[] names = { "Anne", "Ben", "Carrie", "Dean" };
            
            // using a language extension add a new element
            names = names.AddToArray("Karen");


            Console.WriteLine($"Skip names[0] -> {names[0]}");
            foreach (var name in names[1..])
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");

            Console.WriteLine("Get last three names");
            // ^0 is implied
            var lastThree = names[2..^0];

            for (int index = 0; index < lastThree.Length; index++)
            {
                Console.WriteLine(lastThree[index]);
            }

        }
    }
}
