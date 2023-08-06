using DataGridViewComboBoxCore.Classes;
using System.Data;
using System.Diagnostics;
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).

namespace DataGridViewComboBoxCore;

public partial class Form1 : Form
{
    readonly BindingSource _customerBindingSource = new();
    readonly BindingSource _colorBindingSource = new();
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {
        Setup();
        CustomersDataGridView.AllowUserToAddRows = false;
    }

    private void Setup()
    {

        CustomersDataGridView.AutoGenerateColumns = false;

        var (customerTable, colorTable) = DataOperations.LoadData();

        _colorBindingSource.DataSource = colorTable;

        ColorComboBoxColumn.DisplayMember = "ColorText";
        ColorComboBoxColumn.ValueMember = "ColorId";
        ColorComboBoxColumn.DataPropertyName = "ColorId";

        ColorComboBoxColumn.DataSource = _colorBindingSource;

        ColorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

        ItemTextBoxColumn.DataPropertyName = "Item";
        _customerBindingSource.DataSource = customerTable;

        coreBindingNavigator1.BindingSource = _customerBindingSource;
        coreBindingNavigator1.DisableAddNewItems();
        coreBindingNavigator1.DisableRemoveItems();
        CustomersDataGridView.DataSource = _customerBindingSource;

        CustomersDataGridView.EditingControlShowing += CustomersDataGridViewOnEditingControlShowing!;

        ColorIdLabel.DataBindings.Add("Text", _customerBindingSource, "ColorId", true);


    }
    private void CustomersDataGridViewOnEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        if (!CustomersDataGridView.CurrentCell.IsComboBoxCell()) return;
        if (CustomersDataGridView.Columns[CustomersDataGridView.CurrentCell.ColumnIndex].Name != nameof(ColorComboBoxColumn)) return;
        if (!(e is { Control: ComboBox cb })) return;
        cb.SelectionChangeCommitted -= SelectionChangeCommitted;
        cb.SelectionChangeCommitted += SelectionChangeCommitted;
    }

    private void SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (_customerBindingSource.Current == null) return;
        if (!string.IsNullOrWhiteSpace(((DataGridViewComboBoxEditingControl)sender).Text))
        {
            DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;

            ColorIdLabel.Text = currentRow.Field<int>("ColorId").ToString();
        }
    }

    private void CurrentButton_Click(object sender, EventArgs e)
    {
        var customerRow = ((DataRowView)_customerBindingSource.Current).Row;

        var colorName = (_colorBindingSource.DataSource as DataTable).AsEnumerable()
            .FirstOrDefault(row => row.Field<int>("ColorId") == customerRow.Field<int>("ColorId"))
            .Field<string>("ColorText");
        Debug.WriteLine(colorName);
    }

    private void SetCurrentColorButton_Click(object sender, EventArgs e)
    {
        DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;
        currentRow.SetField("ColorId", -1);
    }

    private void IterateRowsButton_Click(object sender, EventArgs e)
    {
        var productTable = (DataTable)_customerBindingSource.DataSource;
        var colorTable = (DataTable)_colorBindingSource.DataSource;

        for (int rowIndex = 0; rowIndex < productTable.Rows.Count; rowIndex++)
        {
            var productName = productTable.Rows[rowIndex].Field<string>("Item");
            var colorIdentifier = productTable.Rows[rowIndex].Field<int>("ColorId");

            var colorName = colorTable
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ColorId") == colorIdentifier)
                .Field<string>("ColorText");


            Debug.WriteLine($"{rowIndex,-5}{productName,-15}{colorName}");
        }
    }
}
