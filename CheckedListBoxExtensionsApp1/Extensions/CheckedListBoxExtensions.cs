using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CheckedListBoxExtensionsApp1.Extensions
{
    public static class CheckedListBoxExtensions
    {
        /// <summary>
        /// Get checked items as <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Model</typeparam>
        /// <param name="sender">CheckedListBox</param>
        /// <returns>List if one or more items are checked</returns>
        public static List<T> CheckedList<T>(this CheckedListBox sender)
            => sender.Items.Cast<T>()
                .Where((_, index) => sender.GetItemChecked(index))
                .Select(item => item)
                .ToList();

        /// <summary>
        /// Uncheck all items
        /// </summary>
        /// <param name="sender">CheckedListBox</param>
        public static void UnCheckAll(this CheckedListBox sender)
        {
            foreach (int index in sender.CheckedIndices)
            {
                sender.SetItemCheckState(index, CheckState.Unchecked);
            }
        }
    }
}
