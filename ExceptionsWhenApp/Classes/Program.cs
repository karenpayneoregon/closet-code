using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

// ReSharper disable once CheckNamespace
namespace ExceptionsWhenApp
{
    partial class Program
    {
        private static void WriteLineForContinue(string text)
        {
            Render(
                new Rule(text)
                    .RuleStyle(Style.Parse("white"))
                    .HeavyBorder()
                    .Centered());
        }
        private static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }
    }
}
