using System;
using System.Linq;
using CodeWithNoForesight_grouping.Models;
using Microsoft.EntityFrameworkCore;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace CodeWithNoForesight_grouping.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
