using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BindingListLibrary.LanguageExtensions;
using MockingPeopleLibrary.Classes;
using MockingPeopleLibrary.Models;

namespace BindingListAddRangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BindingList<Person> bindingList = new();

            var people = BogusOperations.PeopleList(5);

            bindingList.AddRange(people);

            foreach (var person in bindingList)
            {
                Console.WriteLine($"{person.FirstName, -10}{person.LastName}");
                foreach (var address in person.Addresses)
                {
                    Console.WriteLine($"\t{address.Street, -30}{address.PostalCode}");
                }
            }

            Console.ReadLine();
        }

            [ModuleInitializer]
            public static void Init()
            {
                Console.Title = "Code sample - BindList AddRange extension";
            }
    }
}
