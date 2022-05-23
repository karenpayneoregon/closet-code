using System;
using System.Collections.Generic;
using System.IO;
using SpreadsheetLight;
using SpreadSheetLiteConsoleApp.Models;

namespace SpreadSheetLiteConsoleApp.Classes
{
    public class ExcelOperations
    {
        /// <summary>
        /// Locate text in used cells
        /// </summary>
        /// <param name="searchItem"><seealso cref="SearchItem"/></param>
        /// <returns>Named value tuple list of <seealso cref="FoundItemImmutable"/> and <seealso cref="Exception"/></returns>
        /// <remarks>
        /// Optional, add logic for like/contains
        /// </remarks>
        public static (IReadOnlyList<FoundItemImmutable> items, Exception exception) FindText(SearchItem searchItem)
        {

            List<FoundItemImmutable> foundList = new();

            try
            {
                using (var document = new SLDocument(searchItem.FileName, searchItem.SheetName))
                {

                    var stats = document.GetWorksheetStatistics();

                    for (int columnIndex = 1; columnIndex < stats.EndColumnIndex + 1; columnIndex++)
                    {

                        for (int rowIndex = 1; rowIndex < stats.EndRowIndex + 1; rowIndex++)
                        {
                            if (document.GetCellValueAsString(rowIndex, columnIndex).Equals(searchItem.Token, searchItem.StringComparison))
                            {
                                foundList.Add(new FoundItemImmutable(rowIndex, columnIndex, SLConvert.ToColumnName(columnIndex)));
                            }
                        }
                    }

                }

                return (foundList, null);

            }
            catch (Exception exception)
            {
                return (foundList, exception);
            }

        }
     
    }
}