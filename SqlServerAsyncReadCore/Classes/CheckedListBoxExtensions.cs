using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SqlServerAsyncReadCore.Classes
{
    public static partial class CheckedListBoxExtensions
    {
        /// <summary>
        /// Raw method for inspecting data in a <see cref="CheckedListBox"/> where the DataSource is a <see cref="DataTable"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="primaryKeyName">Primary key in DataTable</param>
        /// <returns>List of <see cref="CheckedData"/></returns>
        public static List<CheckedData> IndexList(this CheckedListBox sender, string primaryKeyName)
        {
            if (primaryKeyName == null) throw new ArgumentNullException(nameof(primaryKeyName));

            return (sender.Items.Cast<DataRowView>()
                .Select((dataRowView, index) => new CheckedData { Row = dataRowView.Row, Index = index, Identifier = dataRowView.Row.Field<int>(primaryKeyName) })
                .Where((checkedData) => sender.GetItemChecked(checkedData.Index))
                .Select(checkedData => checkedData)).ToList();
        }
        /// <summary>
        /// Raw method for inspecting data in a <see cref="CheckedListBox"/> where the DataSource is a <see cref="DataTable"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="primaryKeyName">Primary key in DataTable</param>
        /// <param name="displayName">column name to represent the row</param>
        /// <returns>List of <see cref="CheckedData"/></returns>
        public static List<CheckedData> IndexList(this CheckedListBox sender, string primaryKeyName, string displayName)
        {
            if (primaryKeyName == null) throw new ArgumentNullException(nameof(primaryKeyName));
            if (displayName == null) throw new ArgumentNullException(nameof(displayName));

            return
            (
                from checkedData in sender.Items.Cast<DataRowView>()
                    .Select(
                        (dataRowView, index) =>
                            new CheckedData
                            {
                                Row = dataRowView.Row,
                                Index = index,
                                Identifier = dataRowView.Row.Field<int>(primaryKeyName),
                                Label = dataRowView.Row.Field<string>(displayName)
                            }
                    )
                    .Where((checkedData) => sender.GetItemChecked(checkedData.Index))
                select checkedData
            ).ToList();
        }
        /// <summary>
        /// Get checked items into a list of <see cref="ProductItem"/> in a <see cref="CheckedListBox"/> where the DataSource is a <see cref="DataTable"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="primaryKeyName">Primary key in DataTable</param>
        /// <returns>List of <see cref="ProductItem"/></returns>
        public static List<ProductItem> ProductSelectedList(this CheckedListBox sender, string primaryKeyName)
        {
            return
            (
                from item in sender.Items.Cast<DataRowView>()
                    .Select(
                        (dataRowView, index) =>
                            new ProductItem
                            {
                                Index = index,
                                Identifier = dataRowView.Row.Field<int>(primaryKeyName),
                                ProductName = dataRowView.Row.Field<string>("ProductName")

                            }
                    )
                    .Where((productItem) => sender.GetItemChecked(productItem.Index))
                select item
            ).ToList();
        }
    }
}