using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BindingListLibrary.LanguageExtensions;
using MockingPeopleLibrary.Classes;
using MockingPeopleLibrary.Models;
using Spectre.Console;

namespace BindingListAddRangeApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BindingList<Person> bindingList = new();
            var table = GenericTable("People");
            var people = BogusOperations.PeopleList(5);

            bindingList.AddRange(people);

            foreach (var person in bindingList)
            {
                table.AddRow($@"{person.FirstName,-10}{person.LastName}");
                foreach (var address in person.Addresses)
                {
                    table.AddRow("",$"{address.Street}", $"{address.PostalCode}");
                }
            }

            AnsiConsole.Write(table);
            Console.ReadLine();
        }


    }
}
