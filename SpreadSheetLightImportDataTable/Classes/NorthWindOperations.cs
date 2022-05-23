
using System;
using NorthWind2020Library.Models;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Spreadsheet;
using FastMember;
using SpreadsheetLight;

namespace SpreadSheetLightImportDataTable.Classes
{
    public class NorthWindOperations
    {
        /// <summary>
        /// Convert a list to a DataTable for SpreadSheetLight to import using one method.
        /// </summary>
        /// <param name="list">list to place into an Excel file</param>
        /// <param name="fileName">Where to save</param>
        /// <remarks>
        /// No try/catch, instead the caller uses catch-when
        /// </remarks>
        public static void CustomersToExcel(List<CustomersForExcel> list, string fileName)
        {
            // SpreadSheetLight also has a DataTable so we must point to the correct class.
            System.Data.DataTable table = new();

            // 
            using var reader = ObjectReader.Create(list);

            table.Load(reader);

            table.Columns["Title"].SetOrdinal(1);
            table.Columns["CompanyName"].ColumnName = "Company";

            using var document = new SLDocument();

            SLStyle headerStyle = document.CreateStyle();
            headerStyle.Font.Bold = true;
            headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Right;

            var stats = document.GetWorksheetStatistics();

            document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);
            document.AutoFitColumn(1, stats.EndColumnIndex);
            document.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Customers");
            document.SetRowStyle(1, headerStyle);

            document.SaveAs(fileName);
            
        }
    }
}
