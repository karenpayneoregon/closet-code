using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataGridViewExportTextFile.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void ExportRows(this DataGridView sender, string fileName, string defaultNullValue = "(empty)")
        {
            File.WriteAllLines(fileName, (sender.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new {
                    row,
                    rowItem = string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                        .ToArray(), c => ((c.Value == null) ? defaultNullValue : c.Value.ToString())))
                })
                .Select(@row => @row.rowItem)));
        }
        public static void FixHeaders(this DataGridView source)
        {
            for (int index = 0; index < source.Columns.Count; index++)
            {
                source.Columns[index].HeaderText = source.Columns[index].HeaderText.SplitCamelCase();
            }
        }
        public static string SplitCamelCase(this string sender) =>
            Regex.Replace(Regex.Replace(sender,
                    "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"),
                "(\\p{Ll})(\\P{Ll})", "$1 $2");

        public static void ExpandColumns(this DataGridView source, bool sizable = true)
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
                source.Columns[index].Width = columnWidth;
            }


        }
    }
}
