﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseLibraryEntityFramework.Models
{
    public partial class Customer
    {
        public int Identifier { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public int? ContactTypeIdentifier { get; set; }
        [Required]
        public int? GenderIdentifier { get; set; }

        public virtual ContactTypes ContactTypeIdentifierNavigation { get; set; }
        public virtual Genders GenderIdentifierNavigation { get; set; }

        public override string ToString() => CompanyName;

    }
}