using System;
using System.Linq;
using HasConversion.Models;
using Microsoft.EntityFrameworkCore;

namespace HasConversion.Data
{
    public class WineContext : DbContext
    {
        public DbSet<Wine> Wines { get; set; }
        public DbSet<WineVariant> WineVariants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=wines;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Wine>()
                .Property(e => e.WineVariantId)
                .HasConversion<int>();

            modelBuilder
                .Entity<WineVariant>()
                .Property(e => e.WineVariantId)
                .HasConversion<int>();

            modelBuilder
                .Entity<WineVariant>().HasData(
                    Enum.GetValues(typeof(WineVariantId))
                        .Cast<WineVariantId>()
                        .Select(e => new WineVariant()
                        {
                            WineVariantId = e,
                            Name = e.ToString()
                        })
                );
        }
    }
}
