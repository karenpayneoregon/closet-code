using System;
using System.Collections.Generic;
using Spectre.Console;
using TinkeringConsoleApp.Extensions;
using TinkeringConsoleApp.Interfaces;
using TinkeringConsoleApp.Models;

namespace TinkeringConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 8, 10 };

            Console.WriteLine(string.Join(",", array.FindMissing()));
            Console.WriteLine(string.Join(",", array.Missing()));
            Console.WriteLine(string.Join(",", array.Missing1()));

            AnsiConsole.MarkupLine($"[b]{string.Join(",", PeopleList().MissingIdentifiers())}[/]");


            Console.ReadLine();
        }

        private static List<IEmployee> PeopleList() => new()
        {
            new Employee() { Identifier = 1,  FirstName = "Joe", LastName = "Adams" },
            new Employee() { Identifier = 2,  FirstName = "Mary", LastName = "Smith" },
            new Manager()  { Identifier = 3,  FirstName = "Frank", LastName = "O'Brien", 
                Employees = new List<int>() { 2,5,6 } },

            new Employee() { Identifier = 5,  FirstName = "Lee", LastName = "Fux" },

            new Manager()  { Identifier = 6,  FirstName = "Sue", LastName = "Gallagher", 
                Employees = new List<int>() { 1, 3, 8 , 10 } },

            new Employee() { Identifier = 8,  FirstName = "Bob", LastName = "Clime" },
            new Employee() { Identifier = 10, FirstName = "Nancy", LastName = "Burger" }
        };

    }
}
