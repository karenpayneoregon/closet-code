﻿namespace AsyncSimple.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasDiscount { get; set; }
        public int Discount { get; set; }
    }
}