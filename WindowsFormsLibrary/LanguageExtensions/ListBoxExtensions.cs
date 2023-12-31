using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
// ReSharper disable CoVariantArrayConversion

namespace WindowsFormsLibrary.LanguageExtensions
{
    public static class ListBoxExtensions
    {
        /// <summary>
        /// Save unbound items to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="FileName">File to save items too</param>
        /// <remarks></remarks>
        public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName)
        {
            File.WriteAllLines(FileName, sender.Cast<string>().Select(Row => Row).ToArray());
        }

        /// <summary>
        /// Save unbound items to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="FileName">File to save items too</param>
        /// <param name="Append">Indicates whether new contents should be appended to existing file</param>
        /// <remarks></remarks>
        public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName, bool Append)
        {
            var Items = sender.Cast<string>().Select(Row => Row).ToList();

            if (Append)
            {
                if (File.Exists(FileName))
                {
                    var CurrentFileLines = File.ReadAllLines(FileName).ToList();
                    Items.AddRange(CurrentFileLines);
                }
            }

            File.WriteAllLines(FileName, Items.ToArray());

        }
        /// <summary>
        /// Save one column of a bound listbox to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="FileName">File to save items too</param>
        /// <param name="ColumnName">Name of column to write to disk</param>
        /// <remarks></remarks>
        public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName, string ColumnName)
        {
            File.WriteAllLines(FileName, sender.Cast<DataRowView>().Select(Row => Convert.ToString(Row[ColumnName])).ToArray()!);
        }

        /// <summary>
        /// Save one column of a bound listbox to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="FileName">File to save items too</param>
        /// <param name="ColumnIndex">Index of column to write to disk</param>
        /// <remarks></remarks>
        public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName, int ColumnIndex)
        {
            File.WriteAllLines(FileName, sender.Cast<DataRowView>().Select(Row => Convert.ToString(Row[ColumnIndex])).ToArray()!);
        }

        public static void LoadFromFile(this ListBox.ObjectCollection sender, string FileName)
        {
            if (File.Exists(FileName))
            {
                sender.AddRange(File.ReadAllLines(FileName));
            }
        }
    }
}
