using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLibrary.LanguageExtensions
{
    public static class DataGridViewExtensions
    {
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

        /// <summary>
        /// Given a DataGridView populates without a data source, create a DataTable, populate from rows/cells from the
        /// DataGridView with an option to include/exclude column names.
        /// </summary>
        /// <param name="sender">DataGridView to convert contents to a DataTable</param>
        /// <param name="pColumnNames">Include column names</param>
        /// <returns>A DataTable or if not able to convert an exception is thrown</returns>
        /// <remarks>
        /// There is no attempt made to figure out data types coming from data in the DataGridView
        /// </remarks>
        public static DataTable GetDataTable(this DataGridView sender, bool pColumnNames = true)
        {
            var table = new DataTable();

            foreach (DataGridViewColumn column in sender.Columns)
            {
                if (!column.Visible) continue;

                if (pColumnNames)
                {
                    table.Columns.Add(new DataColumn() { ColumnName = column.Name });
                }
                else
                {
                    table.Columns.Add();
                }
            }

            var cellValues = new object[sender.Columns.Count];

            foreach (DataGridViewRow row in sender.Rows)
            {
                if (row.IsNewRow) continue;

                for (int index = 0; index < row.Cells.Count; index++)
                {
                    cellValues[index] = row.Cells[index].Value;
                }

                table.Rows.Add(cellValues);
            }

            return table;

        }

    }
}
