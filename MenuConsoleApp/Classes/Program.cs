using System;
using System.Runtime.CompilerServices;
using MenuConsoleApp.Models;
using Spectre.Console;

// ReSharper disable once CheckNamespace
namespace MenuConsoleApp
{
    partial class Program
    {
        /// <summary>
        /// Sets title and highlight color of prompt
        /// </summary>
        /// <returns><see cref="Spectre.Console.SelectionPrompt"/></returns>
        private static SelectionPrompt<Categories> ConfigureSelectionPrompt()
        {
            SelectionPrompt<Categories> selection = new SelectionPrompt<Categories>().Title("Select[b] [white]category[/][/] to show products");
            selection.HighlightStyle = new Style(Color.DodgerBlue1, Color.Black, Decoration.None);
            return selection;
        }

        /// <summary>
        /// Header for showing which category products are for
        /// </summary>
        /// <param name="categories"></param>
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
