using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SpreadSheetLightImportDataTable.Classes
{
    public class SheetHelpers
    {
        public delegate void OnErrorDelegate(Exception exception);
        public static event OnErrorDelegate OnErrorEvent;

        public static bool SheetExists(SLDocument document, string sheetName) 
            => document.GetSheetNames(false).Any((name) 
                => string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));

        public static List<string> SheetNames(string fileName)
        {
            using var document = new SLDocument(fileName);
            return document.GetSheetNames(false);
        }

        public static bool RemoveWorkSheet(string fileName, string sheetName)
        {
            using var document = new SLDocument(fileName);
            var workSheets = document.GetSheetNames(false);

            if (workSheets.Any((name) => string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase)))
            {

                if (workSheets.Count > 1)
                {
                    document.SelectWorksheet(document.GetSheetNames().FirstOrDefault((name) => !string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase)));
                }
                else if (workSheets.Count == 1)
                {
                    OnErrorEvent?.Invoke(new Exception("Can not delete the sole worksheet"));
                }

                document.DeleteWorksheet(sheetName);
                document.Save();

                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool AddNewSheet(string fileName, string sheetName)
        {
            
            using var document = new SLDocument(fileName);

            if (!(SheetExists(document, sheetName)))
            {

                document.AddWorksheet(sheetName);
                document.Save();

                return true;

            }
            else
            {
                return false;
            }
        }

        public static void AddSheets(string fileName, List<string> nameList)
        {
            int counter = 0;

            using var document = new SLDocument(fileName);

            foreach (var name in nameList.Where(name => !SheetExists(document, name)))
            {
                document.AddWorksheet(name);
                counter += 1;

            }

            if (counter > 0)
            {
                document.Save();
            }

        }
        /// <summary>
        /// Create a new Excel file, rename the default sheet from
        /// Sheet1 to the value in pSheetName
        /// </summary>
        /// <param name="pFileName"></param>
        /// <param name="pSheetName"></param>
        /// <returns></returns>
        public bool CreateNewFile(string pFileName, string pSheetName)
        {
            using var document = new SLDocument();
            document.RenameWorksheet("Sheet1", pSheetName);
            document.SaveAs(pFileName);
            return true;
        }
        /// <summary>
        /// Framework for
        /// * Create a new Excel file
        /// * Creating sheets
        /// * Styling header row
        ///
        /// - By adding a parameter for a DataTable you can perform an import via ImportDataTable as shown
        ///   in ExcelOperations.Export method
        /// - Any styling and alignment can be done by reading the docs at https://spreadsheetlight.com/
        ///   which is in the form of a .chm and can be downloaded.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="nameList"></param>
        /// <param name="headerDictionary"></param>
        /// <returns></returns>
        public static (bool success, Exception exception) CreateWithSheets(string fileName, List<string> nameList, Dictionary<string, string> headerDictionary)
        {
            try
            {
                using SLDocument document = new ();
                SLStyle headerStyle = document.CreateStyle();
                headerStyle.Font.Bold = true;
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;


                foreach (var name in nameList.Where(name => !SheetExists(document, name)))
                {
                    document.AddWorksheet(name);
                    document.SelectWorksheet(name);

                    foreach (var kvp in headerDictionary)
                    {
                        document.SetCellValue(kvp.Key, kvp.Value);
                    }


                    document.SetRowStyle(1, headerStyle);

                }

                document.DeleteWorksheet("Sheet1");
                document.SaveAs(fileName);

                return (true, null);
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }
        /// <summary>
        /// Get last row in <see cref="pFileName"/> for <see cref="pSheetName"/>
        /// </summary>
        /// <param name="pFileName">Existing file name</param>
        /// <param name="pSheetName">Existing sheet</param>
        /// <returns>Last row or zero</returns>
        /// <remarks>
        /// if unsure if sheet exists use <see cref="SheetExists"/> first
        /// </remarks>
        public int GetWorkSheetLastRow(string pFileName, string pSheetName)
        {
            var lastRow = 0;

            using var document = new SLDocument(pFileName, pSheetName);
            /*
             * get statistics, in this case we want the last used row so we
             * simply index into EndRowIndex yet there are more properties.
             */
            lastRow = document.GetWorksheetStatistics().EndRowIndex;

            return lastRow;
        }
    }
}


