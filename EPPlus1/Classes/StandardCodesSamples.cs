using System;
using System.Collections.Generic;
using System.Data;

using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EPPlus1.Models;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using Spectre.Console;
//using Formatting = System.Xml.Formatting;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace EPPlus1.Classes
{
    public class StandardCodesSamples
    {

        private static string _excelBaseFolder => "ExcelFiles";

        public static void CreateNewFile()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _excelBaseFolder, "NewFile.xlsx");

            using var package = new ExcelPackage();

            var worksheet = package.Workbook.Worksheets.Add("FirstSheet");
            package.Workbook.Properties.Company = "Some company";
            package.Workbook.Properties.Comments = "Code sample";
            package.Workbook.Properties.Author = "Karen Payne";

            package.SaveAs(filePath);

        }

        public static void CreateNewFileWithData()
        {
            DataOperations.Contacts(_excelBaseFolder);

        }

        /// <summary>
        /// </summary>
        public static void Sample1()
        {

            Table customerTable = ConsoleOperations.DisplayTable();
            
            var filePath = FileUtil.GetFileInfo(_excelBaseFolder, "Customers.xlsx").FullName;

            Console.WriteLine("Reading {0}", filePath);
            Console.WriteLine();

            FileInfo existingFile = new(filePath);
            using ExcelPackage package = new(existingFile);
            
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            
            var lastRow = worksheet.Dimension.End.Row;
            var lastColumn = worksheet.Dimension.End.Column;

            Console.WriteLine($"Row: {lastRow} Col: {lastColumn}");

            List<CustomerExcelItem> list = new();

            for (int rowIndex = 2; rowIndex < lastRow; rowIndex++)
            {
                var modDateValue = worksheet.Cells[rowIndex, 6].Text;
                var idValue = worksheet.Cells[rowIndex, lastColumn].Text;

                if (DateTime.TryParse(modDateValue, out var modifiedDate) && int.TryParse(idValue, out var id))
                {
                    list.Add(new CustomerExcelItem()
                    {
                        RowIndex = rowIndex,
                        Id = id, 
                        CompanyName = worksheet.Cells[rowIndex, 1].Text,
                        Title = worksheet.Cells[rowIndex, 2].Text,
                        Contact = worksheet.Cells[rowIndex, 3].Text,
                        Country = worksheet.Cells[rowIndex, 4].Text,
                        Phone = worksheet.Cells[rowIndex, 5].Text,
                        ModifiedDate = modifiedDate
                    });
                }
            }


            foreach (var item in list)
            {

                customerTable.AddRow(
                    item.RowIndex.ToString(),
                    item.Id.ToString(),
                    item.CompanyName,
                    item.Title,
                    item.Contact,
                    item.Country,
                    item.Phone,
                    item.ModifiedDate?.ToString("d")!
                );
            }

            AnsiConsole.Write(customerTable);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(list, options);
            File.WriteAllText("Exported.json", jsonString);

        }
        public static void Sample2()
        {

            Table customerTable = ConsoleOperations.DisplayTable();

            var filePath = FileUtil.GetFileInfo(_excelBaseFolder, "Customers.xlsx").FullName;

            FileInfo existingFile = new(filePath);
            using ExcelPackage package = new(existingFile);

            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            var lastRow = worksheet.Dimension.End.Row;
            var lastColumn = worksheet.Dimension.End.Column;

            List<CustomerExcelItem> list = new();

            for (int rowIndex = 2; rowIndex < lastRow; rowIndex++)
            {
                var modDateValue = worksheet.Cells[rowIndex, 6].Text;
                var idValue = worksheet.Cells[rowIndex, lastColumn].Text;

                if (DateTime.TryParse(modDateValue, out var modifiedDate) && int.TryParse(idValue, out var id))
                {
                    list.Add(new CustomerExcelItem()
                    {
                        RowIndex = rowIndex,
                        Id = id,
                        CompanyName = worksheet.Cells[rowIndex, 1].Text,
                        Title = worksheet.Cells[rowIndex, 2].Text,
                        Contact = worksheet.Cells[rowIndex, 3].Text,
                        Country = worksheet.Cells[rowIndex, 4].Text,
                        Phone = worksheet.Cells[rowIndex, 5].Text,
                        ModifiedDate = modifiedDate
                    });
                }
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(list, options);
            File.WriteAllText("Exported.json", jsonString);

        }

        //string json = JsonConvert.SerializeObject(dt, Formatting.Indented);

        /// <summary>
        /// Export first sheet as a DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable Export()
        {
            var filePath = FileUtil.GetFileInfo(_excelBaseFolder, "Customers.xlsx").FullName;
            FileInfo existingFile = new(filePath);
            using ExcelPackage package = new(existingFile);

            var dataTable = ExcelPackageToDataTable(package);
            
            //create a WorkSheet
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Customers imported");

            //add all the content from the DataTable, starting at cell A1
            worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

            return dataTable;
        }
        public static void ExportToJson()
        {
            /*
             * Points to a folder named ExcelFiles under bin\Debug in this case
             */
            var filePath = FileUtil.GetFileInfo(_excelBaseFolder, "Customers.xlsx").FullName;
            FileInfo existingFile = new(filePath);
            using ExcelPackage package = new(existingFile);

            var dataTable = ExcelPackageToDataTable(package);



            // uses json.net NuGet package
            string jsonString = JsonConvert.SerializeObject(dataTable, Formatting.Indented);
            // write to json in the bin\Debug folder
            File.WriteAllText("Exported1.json", jsonString);
        }

        /// <summary>
        /// Import DataTable, in this case from <see cref="Export"/> method into a new sheet.
        /// For safety, we check if the sheet exists before adding as an exception would be
        /// thrown if we try to add a new sheet when it already exists
        /// </summary>
        /// <param name="dataTable"></param>
        public static void Import(DataTable dataTable)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _excelBaseFolder, "Customers.xlsx");
            FileInfo existingFile = new(filePath);
            using ExcelPackage package = new(existingFile);

            var sheetToAdd = "Imported Customers Demo";

            ExcelWorksheet anotherWorksheet = package.Workbook.Worksheets.FirstOrDefault(sheet => 
                sheet.Name == sheetToAdd);

            if (anotherWorksheet is not null)
            {
                package.Workbook.Worksheets.Delete(anotherWorksheet);
            }

            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(sheetToAdd);

            worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

            worksheet.Cells.AutoFitColumns();

            /*
             * For this to work, all cell headers must be unique else an exception is thrown
             */
            using (ExcelRange range = worksheet.Cells[$"A1:G{worksheet.Dimension.End.Row}"])
            {
                ExcelTableCollection tableCollection = worksheet.Tables;
                ExcelTable table = tableCollection.Add(range, "CustomerTable");
                // https://www.epplussoftware.com/docs/5.8/api/OfficeOpenXml.Table.TableStyles.html
                table.TableStyle = TableStyles.Dark8;
            }

            package.Save();
        }


        public static DataTable ExcelPackageToDataTable(ExcelPackage excelPackage)
        {
            DataTable dt = new();

            // first worksheet
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

            //check if the worksheet is completely empty
            if (worksheet.Dimension == null)
            {
                return dt;
            }

            //create a list to hold the column names
            List<string> columnNames = new();

            //needed to keep track of empty column headers
            int currentColumn = 1;

            //loop all columns in the sheet and add them to the DataTable
            foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                string columnName = cell.Text.Trim();

                //check if the previous header was empty and add it if it was
                if (cell.Start.Column != currentColumn)
                {
                    columnNames.Add("Header_" + currentColumn);
                    dt.Columns.Add("Header_" + currentColumn);
                    currentColumn++;
                }

                //add the column name to the list to count the duplicates
                columnNames.Add(columnName);

                //count the duplicate column names and make them unique to avoid the exception
                //A column named 'Name' already belongs to this DataTable
                int occurrences = columnNames.Count(x => x.Equals(columnName));
                if (occurrences > 1)
                {
                    columnName = columnName + "_" + occurrences;
                }

                //add the column to the DataTable
                dt.Columns.Add(columnName);

                currentColumn++;

            }

            //start adding the contents of the excel file to the DataTable
            for (int index = 2; index <= worksheet.Dimension.End.Row; index++)
            {
                var row = worksheet.Cells[index, 1, index, worksheet.Dimension.End.Column];
                DataRow newRow = dt.NewRow();

                foreach (var cell in row)
                {
                    newRow[cell.Start.Column - 1] = cell.Text;
                }

                dt.Rows.Add(newRow);
            }

            

            return dt;
        }
    }
}
