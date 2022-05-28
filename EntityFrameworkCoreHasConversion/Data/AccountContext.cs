#nullable disable
using System;
using ConfigurationLibrary.Classes;
using HasConversion.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HasConversion.Data
{
    public partial class AccountContext : DbContext
    {
        public AccountContext()
        {
        }

        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationHelper.ConnectionString());
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
