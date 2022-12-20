using System;
using System.IO;
using System.Runtime.CompilerServices;
using EPPlus1.Classes;
using OfficeOpenXml;

namespace EPPlus1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //StandardCodesSamples.CreateNewFile();
            //StandardCodesSamples.CreateNewFileWithData();
            StandardCodesSamples.ExportToJson();
            //ReadAndImportBackInNewWorkSheet();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        /// <summary>
        /// First method reads the first sheet to a DataTable
        /// Second method writes back to same file in a new sheet
        ///
        /// For a real application methods above would be in one method
        /// </summary>
        private static void ReadAndImportBackInNewWorkSheet()
        {
            var table = StandardCodesSamples.Export();
            StandardCodesSamples.Import(table);
        }


        [ModuleInitializer]
        public static void InitializeStuff()
        {
            Console.Title = "Working Excel using EPPlus";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
    }

}
