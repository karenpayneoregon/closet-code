using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EntityFrameworkEnumSimple.Classes;
using EntityFrameworkEnumSimple.Data;
using EntityFrameworkEnumSimple.Models;
using Spectre.Console;

namespace EntityFrameworkEnumSimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                AddRecords(context);
                ShowRecords(context);
            }
            
            Console.ReadLine();
        }

        private static void ShowRecords(BookContext context)
        {
            var table = new Table()
                .RoundedBorder()
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Title[/]")
                .AddColumn("[b]Category[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]Books[/]");

            var books = context.Book.ToList();

            foreach (var book in books)
            {
                table.AddRow(book.BookId.ToString(), book.Title, Enum.GetName(typeof(BookCategory), book.BookCategory)!);
            }

            AnsiConsole.Write(table);
        }

        private static void AddRecords(BookContext context)
        {
            if (context.Book.ToList().Count == 0)
            {
                List<Book> list = new()
                {
                    new() { BookCategory = 5, Title = "First book" },
                    new() { BookCategory = 3, Title = "Second book" },
                    new() { BookCategory = 1, Title = "Third book" }
                };

                context.AddRange(list);
                Console.WriteLine($"Books saved {context.SaveChanges()}");
            }
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"EF Core enums simple";
        }
    }
}
