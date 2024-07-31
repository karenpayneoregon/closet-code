using System.Data;

namespace SqlServerAsyncReadCore.Classes;

public static class BindingSourceExtensions
{
    public static DataTable DataTable(this BindingSource sender)
        => (DataTable)sender.DataSource;
    public static DataView DataView(this BindingSource sender)
        => ((DataTable)sender.DataSource).DefaultView;
    public static void RowFilterStartsWith(this BindingSource sender, string field, string value, bool caseSensitive = false)
    {
        sender.DataTable().CaseSensitive = caseSensitive;
        sender.DataView().RowFilter = $"{field} LIKE '{value.EscapeApostrophe()}%'";
    }
    public static void RowFilterContains(this BindingSource sender, string field, string value, bool caseSensitive = false)
    {
        sender.DataTable().CaseSensitive = caseSensitive;
        sender.DataView().RowFilter = $"{field} LIKE '%{value.EscapeApostrophe()}%'";
    }
    public static void RowFilterEndsWith(this BindingSource sender, string field, string value, bool caseSensitive = false)
    {
        sender.DataTable().CaseSensitive = caseSensitive;
        sender.DataView().RowFilter = $"{field} LIKE '%{value.EscapeApostrophe()}'";
    }
}