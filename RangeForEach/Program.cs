using static System.Globalization.DateTimeFormatInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using RangeForEach.Extensions;

namespace RangeForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForEachIndexingDoesNotCompile();
            //ForEachConventional();
            ForEachIndexing();
            //ForZip();
        }


        private static void ForEachIndexing()
        {
            Debug.WriteLine(nameof(ForEachIndexing));

            var owners = new[] { "Karen", "Bob", "John" };
            var pets   = new[] { "Dog",   "Cat", "Bird" };
            
            Debug.WriteLine("Using Range extension");

            foreach (var index in 1..3)
            {
                Debug.WriteLine($"{owners[index], -4} owns a {pets[index]}");
            }

            Debug.WriteLine("");

            Range range = new Range(1, 3);

            Debug.WriteLine("Using a Range");
            foreach (var index in range)
            {
                Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

        }

        private static void ForZip()
        {
            var owners = new[] { "Karen", "Bob", "John" };
            var animals = new[] { "Dog", "Cat", "Bird" };

            var zippedItems = owners
                .Zip(animals, (owner, pet) => new Pet
                {
                    Owner = owner, 
                    Type = pet
                });

            foreach (Pet pet in zippedItems)
            {
                Debug.WriteLine($"{pet.Owner, -6}{pet.Type}");
            }

        }

        private static void ForEachConventional()
        {
            Debug.WriteLine(nameof(ForEachConventional));

            var owners = new[] { "Karen", "Bob", "John" };
            var pets = new[] { "Dog", "Cat", "Bird" };

            for (int index = 0; index < owners.Length; index++)
            {
                Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

            Debug.WriteLine("");
        }

        
    }
}
