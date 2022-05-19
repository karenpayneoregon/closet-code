﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthWind2020ConsoleApp.Data;
using NorthWind2020ConsoleApp.Models;
using System;

namespace NorthWind2020ConsoleApp.Data.Configurations
{
    public partial class BusinessEntityPhoneConfiguration : IEntityTypeConfiguration<BusinessEntityPhone>
    {
        public void Configure(EntityTypeBuilder<BusinessEntityPhone> entity)
        {
            entity.Property(e => e.BusinessEntityPhoneId).HasColumnName("BusinessEntityPhoneID");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BusinessEntityPhone> entity);
    }
}
