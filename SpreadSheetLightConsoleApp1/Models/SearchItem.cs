using System;

namespace SpreadSheetLiteConsoleApp.Models
{
    public class SearchItem
    {
        /// <summary>
        /// Existing Excel file
        /// </summary>
        public string FileName { get; init; }
        /// <summary>
        /// Sheet name to locate text in
        /// </summary>
        public string SheetName { get; init; }
        /// <summary>
        /// Value to locate
        /// </summary>
        public string Token { get; init; }

        /// <summary>
        /// Comparison to use
        /// </summary>
        public StringComparison StringComparison { get; init; }

        public SearchItem(string fileName, string sheetName, string token, StringComparison stringComparison)
        {
            FileName = fileName;
            SheetName = sheetName;
            Token = token;
            StringComparison = stringComparison;

        }

    }
}
