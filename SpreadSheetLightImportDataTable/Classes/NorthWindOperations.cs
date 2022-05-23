
using System;
using NorthWind2020Library.Models;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Spreadsheet;
using FastMember;
using SpreadsheetLight;
using Color = System.Drawing.Color;

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
            int dateColumnIndex = 6;
            // 
            using var reader = ObjectReader.Create(list);

            table.Load(reader);
            
            table.Columns["Title"].SetOrdinal(1);
            table.Columns["Modified"].SetOrdinal(dateColumnIndex);
            table.Columns["id"].SetOrdinal(6);
            table.Columns["CompanyName"].ColumnName = "Company";

            using var document = new SLDocument();
            var headerStyle = HeaderStye(document);

            SLStyle dateStyle = document.CreateStyle();
            dateStyle.FormatCode = "mm-dd-yyyy";

            document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);
            document.HideColumn(7, 7);
            document.SetColumnStyle(dateColumnIndex, dateStyle);

            for (int columnIndex = 1; columnIndex < table.Columns.Count; columnIndex++)
            {
                document.AutoFitColumn(columnIndex);
            }

            document.AutoFitColumn(dateColumnIndex + 1);
            
            document.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Customers");

            document.SetCellStyle(1, 1, 1, 6, headerStyle);

            // one row below header
            document.SetActiveCell("A2");

            // ensure header is visible when scrolling down
            document.FreezePanes(1,6);

            document.SaveAs(fileName);
            
        }

        public static SLStyle HeaderStye(SLDocument document)
        {
            
            SLStyle headerStyle = document.CreateStyle();

            headerStyle.Font.Bold = true;
            headerStyle.Font.FontColor = Color.White;
            headerStyle.Fill.SetPattern(
                PatternValues.LightGray,
                SLThemeColorIndexValues.Accent1Color,
                SLThemeColorIndexValues.Accent5Color);

            return headerStyle;
        }
    }
}
