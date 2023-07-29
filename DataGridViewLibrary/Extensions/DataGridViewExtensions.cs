using System.Data;

namespace DataGridViewLibrary.Extensions
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


        public static void ExpandColumns(this DataGridView sender, bool sizable = false)
        {
            foreach (DataGridViewColumn col in sender.Columns)
            {
                if (col.ValueType.Name != "ICollection`1")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            if (!sizable) return;

            for (int index = 0; index <= sender.Columns.Count - 1; index++)
            {
                int columnWidth = sender.Columns[index].Width;

                sender.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                sender.Columns[index].Width = columnWidth;
            }
        }

        public static bool IsComboBoxCell(this DataGridViewCell sender)
        {
            var result = false;
            if (sender.EditType == null) return false;
            if (sender.EditType == typeof(DataGridViewComboBoxEditingControl))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Provides very fast and basic column sizing for large data sets.
        /// </summary>
        public static void FastAutoSizeColumns(this DataGridView sender, params string[] includeColumns)
        {
            // Cast out a DataTable from the target grid data source.
            // We need to iterate through all the data in the grid and a DataTable supports enumeration.
            var gridTable = (DataTable)sender.DataSource;

            // Create a graphics object from the target grid. Used for measuring text size.
            using var gfx = sender.CreateGraphics();
            // Iterate through the columns.
            for (int index = 0; index < gridTable.Columns.Count; index++)
            {
                var test = gridTable.Columns[index];
                if (includeColumns.Contains(gridTable.Columns[index].ColumnName))
                {
                    // Leverage Linq enumerator to rapidly collect all the rows into a string array, making sure to exclude null values.
                    string[] colStringCollection = gridTable.AsEnumerable().Where(r => r.Field<object>(index) != null).Select(r => r.Field<object>(index).ToString()).ToArray();

                    // Sort the string array by string lengths.
                    colStringCollection = colStringCollection.OrderBy((x) => x.Length).ToArray();

                    // Get the last and longest string in the array.
                    string longestColString = colStringCollection.Last();

                    // Use the graphics object to measure the string size.
                    var colWidth = gfx.MeasureString(longestColString, sender.Font);

                    // If the calculated width is larger than the column header width, set the new column width.
                    if (colWidth.Width > sender.Columns[index].HeaderCell.Size.Width)
                    {
                        sender.Columns[index].Width = (int)colWidth.Width;
                    }
                    else // Otherwise, set the column width to the header width.
                    {
                        sender.Columns[index].Width = sender.Columns[index].HeaderCell.Size.Width;
                    }
                }
            }
        }
    }

    internal record RowRecord(DataGridViewRow Row, string RowItem);


}
