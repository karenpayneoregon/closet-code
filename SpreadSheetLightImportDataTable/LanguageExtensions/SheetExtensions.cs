using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;

namespace SpreadSheetLightImportDataTable.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class SheetExtensions
    {

        public static bool SheetExists(this SLDocument document, string sheetName) =>
            document.GetSheetNames(false).Any((name) =>
                string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));

    }
}
