using System;
using System.IO;
using System.Linq;
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
    }
}
