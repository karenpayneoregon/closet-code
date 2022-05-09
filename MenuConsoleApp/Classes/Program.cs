using System;
using System.Runtime.CompilerServices;
using MenuConsoleApp.Models;
using Spectre.Console;

// ReSharper disable once CheckNamespace
namespace MenuConsoleApp
{
    partial class Program
    {
        private static void WriteLineForSelected(Categories categories)
        {
            Render(
                new Rule($"products for category [b]{categories.CategoryName}[/]")
                    .RuleStyle(Style.Parse("white"))
                    .HeavyBorder()
                    .Centered());
        }

        private static void WriteLineForContinue()
        {
            Render(
                new Rule($"Press[b] enter[/] to return to menu")
                    .RuleStyle(Style.Parse("white"))
                    .HeavyBorder()
                    .Centered());
        }
        private static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Spectre.Console menu with EF Core";
        }
    }
}
