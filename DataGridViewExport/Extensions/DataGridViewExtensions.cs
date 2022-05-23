using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DataGridViewExport.Extensions
{
    public static class DataGridViewExtensions
    {
        /// <summary>
        /// Write entire contents, rows and cells to a tex file
        /// </summary>
        /// <param name="sender">DataGridView with rows and columns</param>
        /// <param name="pFileName">Path and file name to write too</param>
        /// <param name="defaultNullValue">Default value for null or empty cells</param>
        public static void ExportRows(this DataGridView sender, string pFileName, string defaultNullValue = "(empty)")
        {
            File.WriteAllLines(pFileName, sender.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new RowRecord(
                    row, string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                        .ToArray(), cell => (cell.Value == null) ?
                        defaultNullValue :
                        cell.Value.ToString()))
                ))
                .Select(@row => @row.RowItem));
        }
        /// <summary>
        /// Create a string array from DataGridView rows using by default a comma
        /// between cell data.
        /// </summary>
        /// <param name="sender"><see cref="DataGridView"/></param>
        /// <param name="delimiter">default is a comma, change if another character is desired</param>
        /// <returns>string array representing rows and cells</returns>
        public static string[] CreateRowsArray(this DataGridView sender, string delimiter = ",") =>
            sender.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new { row, rowItem = string.Join(delimiter, Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), cell => (cell.Value == null) ? "" : cell.Value.ToString())) })
                .Select(@t => @t.rowItem)
                .ToArray();

        public static void ExpandColumns(this DataGridView source, bool sizable = false)
        {
            foreach (DataGridViewColumn col in source.Columns)
            {
                if (col.ValueType.Name != "ICollection`1")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            if (!sizable) return;

            for (int index = 0; index <= source.Columns.Count - 1; index++)
            {
                int columnWidth = source.Columns[index].Width;

                source.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                source.Columns[index].Width = columnWidth;
            }


        }

    }

    internal record RowRecord(DataGridViewRow Row, string RowItem);


}
