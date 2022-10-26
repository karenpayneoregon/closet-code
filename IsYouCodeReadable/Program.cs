using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using static System.Globalization.DateTimeFormatInfo;

namespace IsYouCodeReadable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            Ambiguous1();
            Person person = null;

            //DayNamesIndexing();
            //StopUsingSingleCharVariableNames();


            //var xxx = CurrentInfo?.DayNames[^2..^0];
            //var today = DateTime.Now.DayOfWeek.ToString();

            //Console.WriteLine(today);
            //foreach (var name in CurrentInfo?.DayNames)
            //{
            //    Console.WriteLine($"Name: {name, -15}Work day: {IsWorkDay(name),-10}Weekend: {IsWeekendDay(name)}");
            //}

            Console.ReadLine();
        }


        public static bool IsWorkDay(string day) 
            => CurrentInfo?.DayNames[1..6].Contains(day) == true;

        public static bool IsWeekendDay(string day) 
            => !IsWorkDay(day);


        /// <summary>
        /// There are two techniques for testing if a string is null.
        ///
        /// The first uses pattern matching which is easy to use yet
        /// some developers may not understand this and if so either
        /// take time to educate them or use the conventional method
        /// using string.IsNullOrWhiteSpace
        /// </summary>
        private static void Ambiguous()
        {

            Person person = new();
            
            Console.WriteLine("person.FirstName is { } firstName");

            if (person.FirstName is { } firstName)
            {
                Console.WriteLine($"\tFirst Name: {firstName}");
            }
            else
            {
                Console.WriteLine("\tFirst name is null");
            }
            

            Console.WriteLine("!string.IsNullOrWhiteSpace(person.FirstName)");
            if (!string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine($"\tFirst Name: {person.FirstName}");
            }
            else
            {
                Console.WriteLine("\tFirst name is null");
            }

            Console.WriteLine("person.FirstName is {Length: >0}");
            if (person.FirstName is { Length: > 0 })
            {
                Console.WriteLine($"\tFirst Name: {person.FirstName}");
            }
            else
            {
                Console.WriteLine("\tFirst name is null");
            }

            person.FirstName = "Karen";
            Console.WriteLine(person.FirstName is { Length: > 0 } ?
                $"\tFirst Name: {person.FirstName}" :
                "\tFirst name is null");
        }
        private static void Ambiguous1()
        {

            Person person = new();

            if (person.FirstName is { } )
            {
                Console.WriteLine($"\tFirst Name: {person.FirstName}");
            }
            else
            {
                Console.WriteLine("\tFirst name is null");
            }
            
            Console.WriteLine(!string.IsNullOrWhiteSpace(person.FirstName) ? 
                $"\tFirst Name: {person.FirstName}" : "\tFirst name is null");

            Console.WriteLine(person.FirstName is { Length: > 0 } ? 
                $"\tFirst Name: {person.FirstName}" : "\tFirst name is null");


            Console.WriteLine(person!.FirstName is not null ? 
                "\tFirst name is null" : $"\tFirst Name: {person.FirstName}");

            person.FirstName = "Karen";
            Console.WriteLine(person.FirstName is { Length: > 0 } ?
                $"\tFirst Name: {person.FirstName}" :
                "\tFirst name is null");

            if (person.FirstName is { })
            {
                Console.WriteLine($"\tFirst Name: {person.FirstName}");
            }
            else
            {
                Console.WriteLine("\tFirst name is null");
            }
        }


        /// <summary>
        /// Indexing is great as in the first attempt but if developers
        /// don't understand it, educate or use the second method.
        /// </summary>
        private static void DayNamesIndexing()
        {
            var days = CurrentInfo?.DayNames;

            var workDays = days?[1..6];

            // Monday through Friday show day names
            foreach (var day in workDays)
            {
                Console.WriteLine(day);
            }


            Console.WriteLine();

            workDays = days!.Skip(1).Take(5).ToArray();

            foreach (var day in workDays)
            {
                Console.WriteLine(day);
            }


            // in the same realm, educate or use the conventional path
            var monthNames1 = CurrentInfo!.MonthNames[..^1];

            var monthNames2 = CurrentInfo.MonthNames
                .Where(monthName => !string.IsNullOrWhiteSpace(monthName))
                .ToArray();

        }

        /// <summary>
        /// One character variable names are easy to use in a small code set
        /// but in complex code do you remember what that single char variable name
        /// represents? Also, one one character variable names is harder to debug
        /// code when at a breakpoint. So say no to single character variable names
        /// except in a simple predicate e.g. wellDoneResult.FirstOrDefault(x => x.Name == "Sunday");
        /// </summary>
        private static void StopUsingSingleCharVariableNames()
        {
            var days = CurrentInfo?.DayNames;

            var wellDoneResult = days
                .Select((name, index) => new
                {
                    Name = name,
                    Index = index + 1
                }).ToArray();



            for (int index = 0; index < wellDoneResult.Count(); index++)
            {
                Console.WriteLine($"{wellDoneResult[index].Index,-3}{wellDoneResult[index].Name}");
            }

            Console.WriteLine();

            var poorlyDoneResult = days
                .Select((n, x) => new
                {
                    Name = n,
                    Index = x + 1
                }).ToArray();

            for (int index = 0; index < poorlyDoneResult.Count(); index++)
            {
                Console.WriteLine($"{poorlyDoneResult[index].Index,-3}{poorlyDoneResult[index].Name}");
            }

        }

        private static void IsDateAndNotMinValue()
        {
            string value = "1/1/0001 12:00:00 AM";
            Debug.WriteLine(value);
            if (DateTime.TryParse(value, out var date) && date == DateTime.MinValue)
            {
                Console.WriteLine($"No good {date:d}"); // ❌
            }
            else
            {
                Console.WriteLine($"Date is {date:d} "); // ✔
            }
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Does code make sense?";
        }

        public static void Example1()
        {
            var example = new Example(out var demo);
        }

    }

    public class Example
    {
        public Example(out Example example)
        {
            example = this;
        }
    }
}
