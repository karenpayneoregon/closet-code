using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SequenceIssues.LanguageExtensions;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

namespace SequenceIssues
{
    partial class Program
    {
        static void Main(string[] args)
        {


            IsBroken();
            FindMissing();
            Console.ReadLine();
        }

        private static void IsBroken()
        {

            Render(new Rule($"[lightseagreen]{nameof(IsBroken)}[/]")
                    .RuleStyle(Style.Parse("yellow"))
                    .LeftAligned());

            int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };
            Console.WriteLine(array.IsSequenceBroken());
            AnsiConsole.WriteLine();
        }

        private static void FindMissing()
        {

            Render(new Rule($"[lightseagreen]{nameof(FindMissing)}[/]")
                .RuleStyle(Style.Parse("yellow"))
                .LeftAligned());

            int[] array = { 1, 2, 3, 5, 6, 8, 10, 11 };
            List<int> expected = new() { 4, 7, 9 };

            var results = array.FindMissing2();
            Console.WriteLine(expected.SequenceEqual(results.ToList()));
            Console.WriteLine($"Results: {string.Join(",", results)}");
        }


    }
}
