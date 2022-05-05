using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace IsYouCodeReadable
{
    class Program
    {
        static void Main(string[] args)
        {
            Ambiguous();
            //DayNamesIndexing();
            //StopUsingSingleCharVariableNames();

            Console.ReadLine();
        }

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
            if (person.FirstName is {Length: >0})
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

        /// <summary>
        /// Indexing is great as in the first attempt but if developers
        /// don't understand it, educate or use the second method.
        /// </summary>
        private static void DayNamesIndexing()
        {
            var days = DateTimeFormatInfo.CurrentInfo?.DayNames;

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
            var monthNames1 = DateTimeFormatInfo.CurrentInfo!.MonthNames[..^1];

            var monthNames2 = DateTimeFormatInfo.CurrentInfo.MonthNames
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
            var days = DateTimeFormatInfo.CurrentInfo?.DayNames;

            var wellDoneResult = days!
                .Select((name, index) => new
                {
                    Name = name,
                    Index = index +1
                }).ToArray();



            for (int index = 0; index < wellDoneResult.Count(); index++)
            {
                Console.WriteLine($"{wellDoneResult[index].Index,-3}{wellDoneResult[index].Name}");
            }

            Console.WriteLine();

            var poorlyDoneResult = days!
                .Select((n, x) => new
                {
                    Name = n,
                    Index = x +1
                }).ToArray();

            for (int index = 0; index < poorlyDoneResult.Count(); index++)
            {
                Console.WriteLine($"{poorlyDoneResult[index].Index,-3}{poorlyDoneResult[index].Name}");
            }

        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Does code make sense?";
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
    }
}
