using System;
using System.Linq;
using BooksLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookVariant> BookVariants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookLibrary;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Book>()
                .Property(e => e.BookVariantId)
                .HasConversion<int>();

            modelBuilder
                .Entity<BookVariant>()
                .Property(e => e.BookVariantId)
                .HasConversion<int>();

            modelBuilder
                .Entity<BookVariant>().HasData(
                    Enum.GetValues(typeof(BookVariantId))
                        .Cast<BookVariantId>()
                        .Select(e => new BookVariant()
                        {
                            BookVariantId = e,
                            Name = e.ToString()
                        })
                );
        }
    }
}
