using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using CodeWithNoForesight_grouping.Classes;
using CodeWithNoForesight_grouping.Data;
using Spectre.Console;

namespace CodeWithNoForesight_grouping
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //BooksFromDatabase();
            //BooksFromJson();


            
            Console.ReadLine();
        }

        private static void BooksFromJson()
        {
            var books = JsonOperations.BookList();

            var result1 = books
                .GroupBy(book => book.Price < 10 ? 10 : (book.Price < 20 ? 20 : 30))
                .OrderBy(grouping => grouping.Key)
                .ToList();


            foreach (var item in result1)
            {
                Console.WriteLine(item.Key);

                foreach (var book in item)
                {
                    Console.WriteLine($"\t{book.Title,-30}{book.Price}");
                }
            }

            Console.WriteLine(new string('-', 50));

            decimal cheap = 10;
            decimal middle = 20;
            decimal expensive = 30;

            var result2 = books
                .GroupBy(book => book.Price <= cheap ? cheap : (book.Price > cheap && book.Price <= middle ? middle : expensive))
                .Select(group => (@group.Key, @group.ToList()))
                .OrderBy(x => x.Key)
                .ToList();

            foreach (var tuple in result2)
            {
                Console.WriteLine(tuple.Key);
                foreach (var book in tuple.Item2)
                {
                    Console.WriteLine($"\t{book.Title,-30}{book.Price}");
                }
            }

            Console.WriteLine(new string('-', 50));


            var results = books
                .GroupBy(book => book.Price switch
                {
                    <= 10 => "Cheap",
                    > 10 and <= 20 => "Medium",
                    _ => "Expensive"
                })
                .ToDictionary(gb => 
                    gb.Key, 
                    g => g);


            foreach (var item in results)
            {
                Console.WriteLine(item.Key);
                foreach (var book in item.Value)
                {
                    Console.WriteLine($"\t{book.Title,-30}{book.Price}");
                }
            }

            Console.WriteLine(new string('-', 50));

            var mediumPriced = results
                .FirstOrDefault(kvp =>
                    kvp.Value.Key == "Medium");

            foreach (var book in mediumPriced.Value)
            {
                Console.WriteLine($"\t{book.Title,-30}{book.Price}");
            }

        }

        private static void BooksFromDatabase()
        {
            var bookItems = DataOperations.ReadBooks();

            var table = CreateViewTable();

            foreach (var item in bookItems)
            {
                table.AddRow(item.Id.ToString(), item.PriceRange, item.Title, item.Price.ToString("C"));
            }

            AnsiConsole.Write(table);

        }
    }
}
