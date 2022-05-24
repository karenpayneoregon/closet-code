using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Drawing;
using NorthWind2020Library.Classes;
using NorthWind2020Library.Models;
using SpreadSheetLightImportDataTable.Classes;

using IO = System.IO;

namespace SpreadSheetLightExamples
{
    partial class Program
    {
        static void Main(string[] args)
        {

            List<CustomersForExcel> list = CustomerOperations.FromJson();

            try
            {
                NorthWindOperations.CustomersToExcel(list, IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Customers.xlsx"));
                Console.WriteLine("Done");
            }
            catch (Exception exception) when (exception.Message.Contains("The process cannot access the file"))
            {
                Console.WriteLine("Hey you have the spreadsheet open, can not save!!!");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Something went wrong '{exception.Message}'");
            }




            Console.ReadLine();
        }
    }
}
