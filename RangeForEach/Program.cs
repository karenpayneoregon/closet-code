using static System.Globalization.DateTimeFormatInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using RangeForEach.Extensions;
//using RangeForEach.Extensions;
using static System.Globalization.DateTimeFormatInfo;

namespace RangeForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForEachIndexingDoesNotCompile();
            //ForEachConventional();
            //ForEachIndexing();
            //ForEachIndexingForumQuestion();
            //ForZip();
            ForEachIndexingForumQuestion3();
        }

        private static void ForEachIndexingForumQuestion3()
        {

            //var intList = Enumerable.Range(10, 11).ToList();
            //for (int index = intList.Count; index != 0; index--)
            //{
            //    var currentIndex = new Index(index, true);
            //    Console.WriteLine($"{currentIndex,-5}{intList[currentIndex]}");
            //}

            Console.WriteLine();

            var reversed = Enumerable.Range(10, 11).Reverse().ToList();
            foreach (var index in ..reversed.Count)
            {
                Console.WriteLine($"{index,-5}{reversed[index]}");
            }

            Console.ReadLine();
        }
        private static void ForEachIndexingForumQuestion()
        {
            var intList = Enumerable.Range(10, 11).ToList();
            Range range = new Range(1, intList.Count);
            foreach (var index in range)
            {
                Console.WriteLine($"{index,-3}{intList[index]}");
            }

            Console.ReadLine();

        }
        private static void ForEachIndexingForumQuestion2()
        {
            var intList = Enumerable.Range(10, 11).ToList();

            foreach (var index in 1..intList.Count)
            {
                Console.WriteLine($"{index,-3}{intList[index]}");
            }

            Console.ReadLine();

        }


        private static void ForEachIndexing()
        {
            Debug.WriteLine(nameof(ForEachIndexing));

            var owners = new[] { "Karen", "Bob", "John" };
            var pets = new[] { "Dog", "Cat", "Bird" };

            Console.WriteLine("Using Range extension");

            foreach (var index in 1..3)
            {
                Console.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

            Console.WriteLine("");

            Range range = new Range(1, 3);

            Console.WriteLine("Using a Range");
            foreach (var index in range)
            {
                Console.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

            Console.ReadLine();
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
                Debug.WriteLine($"{pet.Owner,-6}{pet.Type}");
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
