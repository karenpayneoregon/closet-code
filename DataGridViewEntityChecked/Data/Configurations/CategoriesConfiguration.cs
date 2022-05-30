﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataGridViewEntityChecked.Data;
using DataGridViewEntityChecked.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataGridViewEntityChecked.Data.Configurations
{
    public partial class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> entity)
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Categories> entity);
    }
}