using System;
using IFormatProviderExample.Classes;
using IFormatProviderExample.LanguageExtensions;
using IFormatProviderExample.Models;
using Spectre.Console;

namespace IFormatProviderExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            FormatExample();
            Console.ReadLine();
        }
        private static void FormatExample()
        {
            AnsiConsole.MarkupLine($"[yellow]{nameof(FormatExample).SplitCamelCase()}[/]");
            Console.CursorTop = 2;
            var result = FormattableSqlStatement();
            result = result
                .Replace("'", "[hotpink]'[/]")
                .Replace("INSERT INTO", "[deepskyblue1]INSERT INTO[/]")
                .Replace("VALUES", "[deepskyblue1]VALUES[/]");

            AnsiConsole.MarkupLine(result);
        }

        private static string FormattableSqlStatement()
        {

            //  local method
            static string Sql(FormattableString formattable)
            {
                return formattable.ToString(new SqlFormatProvider());
            }

            Person person = new() { Id = 12, FirstName = "Karen", LastName = "Payne", BirthDate = new DateTime(1960, 12, 1) };

            return Sql($"INSERT INTO People(id, FirstName, LastName, BirthDate) VALUES({person.Id}, {person.FirstName}, {person.LastName}, {person.BirthDate})");

        }
    }


}
