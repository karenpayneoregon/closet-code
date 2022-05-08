using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkEnumSimple.Classes;
using EntityFrameworkEnumSimple.Data;
using EntityFrameworkEnumSimple.Models;

namespace EntityFrameworkEnumSimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookContext())
            {
                List<Book> list = new()
                {
                    new () { BookCategory = 5, Title = "First book" },
                    new () { BookCategory = 3, Title = "Second book" },
                    new () { BookCategory = 1, Title = "Third book" }
                };

                context.AddRange(list);
                Console.WriteLine(context.SaveChanges());

                var books = context.Book.ToList();
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.BookId,-4}{book.Title,-15}{(BookCategory)book.BookCategory}");
                }
            }

            Console.ReadLine();
        }
    }
}
