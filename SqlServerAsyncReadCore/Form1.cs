using System.Data;
using SqlServerAsyncReadCore.Classes;

namespace SqlServerAsyncReadCore;
public partial class Form1 : Form
{
    BindingSource _bindingSource = new();
    public Form1()
    {
        InitializeComponent();
        // GetCustomers returns a DataTable
        _bindingSource.DataSource = DataOperations.GetCustomers();
        dataGridView1.DataSource = _bindingSource;
        // resize columns to fit column width from database
        dataGridView1.ExpandColumns();
        FilterTextBox.TextChanged += FilterTextBox_TextChanged;
    }

    private void FilterTextBox_TextChanged(object sender, EventArgs e)
    {
        _bindingSource.RowFilterStartsWith("CompanyName", FilterTextBox.Text);
    }
}

public static class StringExtensions
{
    public static string EscapeApostrophe(this string pSender) 
        => pSender.Replace("'", "''");
}

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