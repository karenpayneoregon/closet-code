﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Debugger1.Data;
using Debugger1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Debugger1.Data.Configurations
{
    public partial class CountriesConfiguration : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> entity)
        {
            entity.HasKey(e => e.CountryIdentifier);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Countries> entity);
    }
}
