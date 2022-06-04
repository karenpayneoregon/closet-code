using System;
using System.Collections.Generic;
using System.Linq;
using BooksLibrary.Data;
using BooksLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Classes
{
    public class BookOperations
    {
        /// <summary>
        /// Create database and tables, populate and return as a list of <see cref="Book"/>
        /// </summary>
        /// <param name="reCreate">Pass true to create for the first time</param>
        public static List<Book> AddViewBooks(bool reCreate = false)
        {
            using var context = new BookContext();
            
            if (reCreate)
            {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Books.Add(new Book
                {
                    Title = "Sports Illustrated",
                    BookVariantId = BookVariantId.Sports
                });

                context.Books.Add(new Book
                {
                    Title = "Friday Night Lights",
                    BookVariantId = BookVariantId.Sports
                });

                context.Books.Add(new Book
                {
                    Title = "The logic of sports betting",
                    BookVariantId = BookVariantId.Sports
                });

                context.Books.Add(new Book
                {
                    Title = "Git for programmers",
                    BookVariantId = BookVariantId.Programming
                });

                context.Books.Add(new Book
                {
                    Title = "The self-taught programmer",
                    BookVariantId = BookVariantId.Programming
                });

                context.Books.Add(new Book
                {
                    Title = "C# Programming",
                    BookVariantId = BookVariantId.Programming
                });

                context.Books.Add(new Book
                {
                    Title = "Beginning Object-Oriented Programming with C#",
                    BookVariantId = BookVariantId.Programming
                });

                context.Books.Add(new Book
                {
                    Title = "Entity Framework Core in Action",
                    BookVariantId = BookVariantId.Programming
                });


                context.Books.Add(new Book
                {
                    Title = "Into the Abyss: An Extraordinary True Story",
                    BookVariantId = BookVariantId.Adventure
                });

                context.Books.Add(new Book
                {
                    Title = "The Terminal List: A Thriller",
                    BookVariantId = BookVariantId.Adventure
                });

                context.Books.Add(new Book
                {
                    Title = "Space Travel: Impossible to Reality",
                    BookVariantId = BookVariantId.SpaceTravel
                });

                context.Books.Add(new Book
                {
                    Title = "Galaxies: Birth and Destiny of Our Universe",
                    BookVariantId = BookVariantId.SpaceTravel
                });

                context.Books.Add(new Book
                {
                    Title = "100 cars that changed the world",
                    BookVariantId = BookVariantId.Automobile
                });

                context.Books.Add(new Book
                {
                    Title = "Classic cars",
                    BookVariantId = BookVariantId.Automobile
                });


                context.Books.Add(new Book
                {
                    Title = "Built for Speed: The World's Fastest Road Cars",
                    BookVariantId = BookVariantId.Automobile
                });

                context.SaveChanges();

            }

 
            return context
                .Books
                .Include(item => item.BookVariant)
                .ToList();

            
            //var sportsBooks = context
            //    .Books
            //    .Where(book => book.BookVariantId == BookVariantId.Sports)
            //    .ToList();

            //var spaceTravelBooks = context
            //    .Books
            //    .Where(book => book.BookVariantId == BookVariantId.SpaceTravel)
            //    .ToList();



        }



    }
}
