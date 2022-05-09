using System;
using System.Threading;
using System.Threading.Tasks;
using EntityFrameworkCoreHelpers.Classes;
using Microsoft.EntityFrameworkCore;
using ShadowProperties.Models;

namespace ShadowProperties.Data
{
    public partial class ShadowContext : DbContext
    {
        private bool _ShowDeleted;

        public ShadowContext(bool showDeleted)
        {
            _ShowDeleted = showDeleted;
        }
        public ShadowContext()
        {
            _ShowDeleted = false;
        }

        public ShadowContext(DbContextOptions<ShadowContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Contact1> Contacts1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                DbContextConnections.NoLogging(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Contact>().Property<DateTime?>("LastUpdated");
            modelBuilder.Entity<Contact>().Property<string>("LastUser");

            modelBuilder.Entity<Contact1>().Property<DateTime?>("LastUpdated");
            modelBuilder.Entity<Contact1>().Property<string>("LastUser");
            modelBuilder.Entity<Contact1>().Property<DateTime?>("CreatedAt");
            modelBuilder.Entity<Contact1>().Property<string>("CreatedBy");
            modelBuilder.Entity<Contact1>().Property<bool>("isDeleted");

            modelBuilder.Entity<Contact>(entity => entity.HasKey(e => e.ContactId));
            modelBuilder.Entity<Contact1>(entity => entity.HasKey(e => e.ContactId));

            /*
             * Setup filter on Contact1 model to show only active records.
             * Since IsDeleted is not in the model the string name is used.
             */
            modelBuilder.Entity<Contact1>()
                .HasQueryFilter(contact =>
                    EF.Property<bool>(contact, "isDeleted") == _ShowDeleted);

            OnModelCreatingPartial(modelBuilder);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new ())
        {
            DoShadowyStuff();
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            DoShadowyStuff();

            return base.SaveChanges();
        }

        private void DoShadowyStuff()
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    entry.Property("LastUpdated").CurrentValue = DateTime.Now;
                    entry.Property("LastUser").CurrentValue = Environment.UserName;

                    if (entry.Entity is Contact1 && entry.State == EntityState.Added)
                    {
                        entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                        entry.Property("CreatedBy").CurrentValue = Environment.UserName;
                    }
                }
                else if (entry.State == EntityState.Deleted)
                {
                    // Change state to modified and set delete flag
                    entry.State = EntityState.Modified;
                    entry.Property("isDeleted").CurrentValue = true;
                }
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}