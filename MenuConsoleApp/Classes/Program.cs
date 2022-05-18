using System;
using System.Runtime.CompilerServices;
using MenuConsoleApp.Classes;
using MenuConsoleApp.Models;
using Spectre.Console;

// ReSharper disable once CheckNamespace
namespace MenuConsoleApp
{
    partial class Program
    {
        private static readonly SelectionPrompt<Products> productMenuelectionPromptStyle = new()
        {
            HighlightStyle = new Style(Color.Aqua, Color.Red, Decoration.Bold)
        };

        private static SelectionPrompt<Categories> CategoryMenu()
        {
            var menu = new SelectionPrompt<Categories>
            {
                HighlightStyle = new Style(Color.DodgerBlue1, Color.Black, Decoration.None)
            };

            menu.Title("Select a [B]category[/]");
            menu.MoreChoicesText("[grey](Move up and down to reveal more categories)[/]");
            menu.AddChoices(DataOperations.Categories());
            return menu;
        }

        /// <summary>
        /// Product menu list
        /// </summary>
        /// <param name="productContinue">used to terminate menu</param>
        /// <param name="categories">Filter products by category identifier</param>
        private static void ProductMenuWork(bool productContinue, Categories categories)
        {

            while (productContinue)
            {

                productMenuelectionPromptStyle.Title("Select a [B]Product[/]");
                productMenuelectionPromptStyle.MoreChoicesText("[grey](Move up and down to reveal more products)[/]");
                productMenuelectionPromptStyle.AddChoices(DataOperations.ProductsMenuList(categories.CategoryId));

                var product = AnsiConsole.Prompt(productMenuelectionPromptStyle);

                if (product.ProductId == -1)
                {
                    productContinue = false;
                }
                else
                {
                    AskConfirmation(product);
                    productContinue = false;
                }

            }
        }

        /// <summary>
        /// Sets title and highlight color of prompt
        /// </summary>
        /// <returns><see cref="Spectre.Console.SelectionPrompt"/></returns>
        private static SelectionPrompt<Categories> ConfigureCategorySelectionPrompt()
        {
            SelectionPrompt<Categories> selection = new SelectionPrompt<Categories>()
                .Title("Select[b] [white]category[/][/] to show products");

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

        private static void ProcessProduct(Products products)
        {
            Console.WriteLine(products.ProductName);
            Console.ReadLine();
        }

        public static void AskConfirmation(Products products)
        {
            if (AnsiConsole.Confirm($"Process [B]{products.ProductName}[/]?"))
            {
                // TODO
            }
            else
            {
                // TODO
            }


        }
    }
}
