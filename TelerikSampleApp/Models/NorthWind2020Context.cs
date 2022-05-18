using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace TelerikSampleApp.Models
{
    public partial class NorthWind2020Context : DbContext
    {
        public NorthWind2020Context()
        {
        }

        public NorthWind2020Context(DbContextOptions<NorthWind2020Context> options) : base(options)
        {
            
        }

        public virtual DbSet<BusinessEntityPhone> BusinessEntityPhones { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactDevice> ContactDevices { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=NorthWind2020;Trusted_Connection=True;");
            //}

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("NorthWind2020Context"));
            }


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BusinessEntityPhone>(entity =>
            {
                entity.ToTable("BusinessEntityPhone");

                entity.Property(e => e.BusinessEntityPhoneId).HasColumnName("BusinessEntityPhoneID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("Primary key");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasOne(d => d.ContactTypeIdentifierNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.ContactTypeIdentifier)
                    .HasConstraintName("FK_Contacts_ContactType");
            });

            modelBuilder.Entity<ContactDevice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactDevices)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_ContactDevices_Contacts1");

                entity.HasOne(d => d.PhoneTypeIdentifierNavigation)
                    .WithMany(p => p.ContactDevices)
                    .HasForeignKey(d => d.PhoneTypeIdentifier)
                    .HasConstraintName("FK_ContactDevices_PhoneType");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasKey(e => e.ContactTypeIdentifier);

                entity.ToTable("ContactType");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryIdentifier);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerIdentifier)
                    .HasName("PK_Customers_1");

                entity.Property(e => e.CustomerIdentifier).HasComment("Id");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasComment("City");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasComment("Company");

                entity.Property(e => e.ContactId).HasComment("ContactId");

                entity.Property(e => e.ContactTypeIdentifier).HasComment("ContactTypeIdentifier");

                entity.Property(e => e.CountryIdentifier).HasComment("CountryIdentifier");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .HasComment("Fax");

                entity.Property(e => e.ModifiedDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Modified Date");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasComment("Phone");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .HasComment("Postal Code");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .HasComment("Region");

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .HasComment("Street");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Customers_Contacts");

                entity.HasOne(d => d.ContactTypeIdentifierNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ContactTypeIdentifier)
                    .HasConstraintName("FK_Customers_ContactType");

                entity.HasOne(d => d.CountryIdentifierNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CountryIdentifier)
                    .HasConstraintName("FK_Customers_Countries");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.Extension).HasMaxLength(4);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.HomePhone).HasMaxLength(24);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);

                entity.HasOne(d => d.ContactTypeIdentifierNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ContactTypeIdentifier)
                    .HasConstraintName("FK_Employees_ContactType");

                entity.HasOne(d => d.CountryIdentifierNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CountryIdentifier)
                    .HasConstraintName("FK_Employees_Countries");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress).HasMaxLength(60);

                entity.Property(e => e.ShipCity).HasMaxLength(15);

                entity.Property(e => e.ShipCountry).HasMaxLength(15);

                entity.Property(e => e.ShipPostalCode).HasMaxLength(10);

                entity.Property(e => e.ShipRegion).HasMaxLength(15);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerIdentifierNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerIdentifier)
                    .HasConstraintName("FK_Orders_Customers2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Orders_Employees");

                entity.HasOne(d => d.ShipViaNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipVia)
                    .HasConstraintName("FK_Orders_Shippers");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK_Order_Details");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Details_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Details_Products");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeIdenitfier);

                entity.ToTable("PhoneType");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Products_Suppliers");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.ShipperId)
                    .ValueGeneratedNever()
                    .HasColumnName("ShipperID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Phone).HasMaxLength(24);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ContactName).HasMaxLength(30);

                entity.Property(e => e.ContactTitle).HasMaxLength(30);

                entity.Property(e => e.Fax).HasMaxLength(24);

                entity.Property(e => e.HomePage).HasColumnType("ntext");

                entity.Property(e => e.Phone).HasMaxLength(24);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.Street).HasMaxLength(60);

                entity.HasOne(d => d.CountryIdentifierNavigation)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.CountryIdentifier)
                    .HasConstraintName("FK_Suppliers_Countries");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
