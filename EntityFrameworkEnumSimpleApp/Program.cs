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
                
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();

                AddRecords(context);
                ShowRecords(context);
            }
            
            Console.ReadLine();
        }

        private static void ShowRecords(BookContext context)
        {
            var allBooksTable = new Table()
                .RoundedBorder()
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Title[/]")
                .AddColumn("[b]Category[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]All books[/]");

            var books = context.Book.ToList();

            foreach (var book in books)
            {
                allBooksTable.AddRow(
                    book.BookId.ToString(),
                    book.Title, 
                    Enum.GetName(typeof(BookCategory), book.BookCategory)!
                    );
            }

            AnsiConsole.Write(allBooksTable);

            var adventureTable = new Table()
                .RoundedBorder()
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Title[/]")
                .AddColumn("[b]Category[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]Adventure books[/]");



            var list = books.Where(x => x.BookCategory == BookCategory.Adventure).ToList();
            foreach (var book in list)
            {
                adventureTable.AddRow(
                    book.BookId.ToString(), 
                    book.Title, 
                    book.BookCategory.ToString());
            }

            AnsiConsole.Write(adventureTable);
        }

        private static void AddRecords(BookContext context)
        {
            if (context.Book.ToList().Count == 0)
            {
                List<Book> list = new()
                {
                    new() { BookCategory = BookCategory.Adventure, Title = "First book" },
                    new() { BookCategory = BookCategory.Automobile, Title = "Second book" },
                    new() { BookCategory = BookCategory.Adventure, Title = "Third book" }
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
