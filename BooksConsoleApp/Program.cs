using System;
using System.Linq;
using BooksLibrary.Classes;
using BooksLibrary.Models;
using Spectre.Console;

namespace BooksConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var bookList = BookOperations.AddViewBooks(false);

            var allBooksTable = new Table()
                .RoundedBorder()
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Title[/]")
                .AddColumn("[b]Category[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]All books[/]");

            foreach (var book in bookList)
            {
                allBooksTable.AddRow(
                    book.BookId.ToString(),
                    book.Title,
                    book.BookVariantId.ToString()
                );
            }

            AnsiConsole.Write(allBooksTable);

            var programmingTable = new Table()
                .RoundedBorder()
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Title[/]")
                .AddColumn("[b]Category[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]Programming books[/]");


            var programmingBooks = bookList
                .Where(books => books.BookVariantId == BookVariantId.Programming)
                .ToList();


            foreach (var book in programmingBooks)
            {

                programmingTable.AddRow(
                    book.BookId.ToString(),
                    book.Title,
                    book.BookVariantId.ToString());

            }

            AnsiConsole.Write(programmingTable);

            Console.ReadLine();

        }
    }
}
