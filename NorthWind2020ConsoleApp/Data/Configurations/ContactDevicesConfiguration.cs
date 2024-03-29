﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthWind2020ConsoleApp.Data;
using NorthWind2020ConsoleApp.Models;
using System;

namespace NorthWind2020ConsoleApp.Data.Configurations
{
    public partial class ContactDevicesConfiguration : IEntityTypeConfiguration<ContactDevices>
    {
        public void Configure(EntityTypeBuilder<ContactDevices> entity)
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

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ContactDevices> entity);
    }
}
