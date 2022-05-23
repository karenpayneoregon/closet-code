using System;
using System.Linq;
using SpreadsheetLight;

namespace SpreadSheetLiteConsoleApp.Classes
{
    public static class Extensions
    {
        public static bool SheetExists(this SLDocument document, string sheetName) =>
            document.GetSheetNames(false).Any((name) => 
                string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));
    }
}