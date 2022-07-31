using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InterfacesUsingAnimals.Classes;
using InterfacesUsingAnimals.Interfaces;
using InterfacesUsingAnimals.Models;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace InterfacesUsingAnimals
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        private static void JustDoIt()
        {
            List<IAnimal> animals = new()
            {
                new Cat() { Name = "Fluffy", Size = Size.Small, Eats = "Mice" },
                new Dog() { Name = "Rin Tin Tin", Size = Size.Medium, Eats = "Dinner scraps" },
                new Tiger() { Name = "Tigger", Size = Size.Large, Eats = "wild pigs" },
                new Rabbit() { Name = "Thumper", Size = Size.Small, Eats = "grass" }
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name,8}:{animal.Name,-15} says {animal.MakeNoise(),6} eats {animal.Eats,15} size: {animal.Size}");
            }
        }
	}
}





