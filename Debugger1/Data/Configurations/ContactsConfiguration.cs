﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Debugger1.Data;
using Debugger1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Debugger1.Data.Configurations
{
    public partial class ContactsConfiguration : IEntityTypeConfiguration<Contacts>
    {
        public void Configure(EntityTypeBuilder<Contacts> entity)
        {
            entity.HasKey(e => e.ContactId);

            entity.HasIndex(e => e.ContactTypeIdentifier, "IX_Contacts_ContactTypeIdentifier");

            entity.Property(e => e.ContactId).HasComment("Id");
            entity.Property(e => e.ContactTypeIdentifier).HasComment("Contact Type key");
            entity.Property(e => e.FirstName).HasComment("First name");
            entity.Property(e => e.FullName)
            .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", false)
            .HasComment("Full name");
            entity.Property(e => e.LastName).HasComment("Last name");

            entity.HasOne(d => d.ContactTypeIdentifierNavigation).WithMany(p => p.Contacts)
            .HasForeignKey(d => d.ContactTypeIdentifier)
            .HasConstraintName("FK_Contacts_ContactType");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Contacts> entity);
    }
}
