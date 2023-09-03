using System.Data;

namespace DataGridViewComboBoxCore.Extensions;
public static class BindingSourceExtensions
{
    /// <summary>
    /// Return DataSource as DataTable
    /// </summary>
    public static DataTable DataTable(this BindingSource sender)
        => (DataTable)sender.DataSource;


    /// <summary>
    /// Given Current is not null return a DataRow
    /// </summary>
    public static DataRow DataRow(this BindingSource sender)
        => ((DataRowView)sender.Current).Row;

}
