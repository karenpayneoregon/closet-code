using System;
using System.Globalization;
using Spectre.Console;

namespace DateTimeAmPm
{
    partial class Program
    {
        static void Main(string[] args)
        {


            AnsiConsole.Write(new Rule($"[yellow]Dealing with AM/PM[/]").LeftAligned().RuleStyle("grey"));

            Console.WriteLine();

            DoConvert1();
            DoConvert2();

            DoConvert2_Array();

            Console.WriteLine();
            AnsiConsole.MarkupLine("[b][white]Done[/][/]");
            Console.ReadLine();

        }

        private static string _dateTimeValue => "31/5/2022 11:00:00 a. m.";

        private static void DoConvert1()
        {

            AnsiConsole.MarkupLine($"[b][white on blue]{nameof(DoConvert1)}[/][/] using replace");

           string cleanedValue = _dateTimeValue
                .Replace("a. m.", "AM")
                .Replace("p. m.", "PM");

            string format = "d/M/yyyy h:mm:ss tt";

            var dateTime = DateTime.ParseExact(cleanedValue, format, CultureInfo.InvariantCulture);

            Console.WriteLine(_dateTimeValue);
            Console.WriteLine(dateTime);
            Console.WriteLine();
        }

        private static void DoConvert2()
        {

            AnsiConsole.MarkupLine($"[b][white on blue]{nameof(DoConvert2)}[/][/] using DateTimeFormatInfo");

            DateTimeFormatInfo formatInfo = new ()
            {
                AMDesignator = "a. m.", 
                PMDesignator = "p. m."
            };

            var dateTime = DateTime.ParseExact(
                _dateTimeValue, 
                "dd/M/yyyy hh:mm:ss tt", 
                formatInfo);

            Console.WriteLine(_dateTimeValue);
            Console.WriteLine(dateTime);
            Console.WriteLine();
        }

        private static void DoConvert2_Array()
        {

            AnsiConsole.MarkupLine($"[b][white on blue]{nameof(DoConvert2_Array)}[/][/] using DateTimeFormatInfo");

            string[] values = { "31/5/2022 11:00:00 a. m.", "31/5/2022 11:00:00 p. m." };

            DateTimeFormatInfo formatInfo = new()
            {
                AMDesignator = "a. m.",
                PMDesignator = "p. m."
            };


            foreach (var value in values)
            {
                var dateTime = DateTime.ParseExact(
                    value,
                    "dd/M/yyyy hh:mm:ss tt",
                    formatInfo);

                Console.WriteLine(_dateTimeValue);
                Console.WriteLine(dateTime);

            }
        }
    }
}
