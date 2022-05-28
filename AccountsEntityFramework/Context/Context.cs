#nullable disable
using System;
using AccountsHasConversion.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AccountsHasConversion.Context
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=EntityFrameworkCoreSamples;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>()
                .Property(e => e.Roles)
                .HasConversion(
                    value => string.Join(',', value),
                    value => value.Split(',', 
                        StringSplitOptions.RemoveEmptyEntries));

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}