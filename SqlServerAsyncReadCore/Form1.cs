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