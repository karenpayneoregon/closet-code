﻿namespace CreateDynamicControls.Classes.Containers
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
