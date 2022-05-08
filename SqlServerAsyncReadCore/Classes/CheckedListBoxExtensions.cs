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
        return
        (
            from item in sender.Items.Cast<DataRowView>()
                .Select(
                    (dataRowView, index) =>
                        new CheckedData
                        {
                            Row = dataRowView.Row,
                            Index = index,
                            Identifier = dataRowView.Row.Field<int>(primaryKeyName)
                        }
                )
                .Where((checkedData) => sender.GetItemChecked(checkedData.Index))
            select item
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