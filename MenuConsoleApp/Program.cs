using System;
using System.IO;
using System.Runtime.CompilerServices;
using MenuConsoleApp.Classes;
using MenuConsoleApp.Models;
using Spectre.Console;

namespace MenuConsoleApp
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var selection = ConfigureSelectionPrompt();

            while (true)
            {
                Categories categories = AnsiConsole.Prompt(
                    selection.Title("Select[b] [white]category[/][/] to show products")
                        .PageSize(10)
                        .AddChoices(DataOperations.Categories()));


                if (categories.CategoryId != -1)
                {
                    Console.Clear();

                    var products = DataOperations.ProductsList(categories.CategoryId);

                    if (products.Count > 0)
                    {
                        WriteLineForSelected(categories);
                        products.ForEach(Console.WriteLine);
                    }
                    else
                    {
                        AnsiConsole.MarkupLine($"No products for [b]{categories.CategoryName}[/]");
                    }

                    WriteLineForContinue();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    return;
                }
            }
        }


    }
}
