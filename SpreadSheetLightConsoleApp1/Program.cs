using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SpreadSheetLiteConsoleApp.Classes;
using SpreadSheetLiteConsoleApp.Models;

namespace SpreadSheetLiteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "karen";

            SearchItem searchItem = new(
                "Demo1.xlsx", 
                "sheet1", 
                value, 
                StringComparison.InvariantCultureIgnoreCase);


            (IReadOnlyList<FoundItemImmutable> items, Exception exception) = ExcelOperations.FindText(searchItem);
            
            if (exception is null)
            {
                if (items.Count >0)
                {
                    Debug.WriteLine($"Found {value} {items.Count} times");
                    foreach (var foundItem in items)
                    {
                        Debug.WriteLine($"{foundItem}");
                    }
                }
                else
                {
                    Debug.WriteLine($"Did not find {value}");
                }

            }
            else
            {
                Debug.WriteLine(exception.Message);
            }
           
            
        }

        [ModuleInitializer]
        public static void Init1()
        {
            Console.Title = "Working with immutable read from Excel";
        }
    }
}
