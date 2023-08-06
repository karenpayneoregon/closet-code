using DataGridViewComboBoxCore.Classes;
using System.Data;
using System.Diagnostics;
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).

namespace DataGridViewComboBoxCore;

public partial class Form1 : Form
{
    private readonly BindingSource _customerBindingSource = new();
    private readonly BindingSource _colorBindingSource = new();

    private DataTable _colorsDataTable;
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

        _colorsDataTable = colorTable;
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

    }


    /// <summary>
    /// Code to get at the current DataGridView row
    /// </summary>
    private void CurrentButton_Click(object sender, EventArgs e)
    {
        DataRow customerRow = ((DataRowView)_customerBindingSource.Current).Row;
        
        int colorIdentifier = (_colorBindingSource.DataSource as DataTable).AsEnumerable()
            .FirstOrDefault(row => row.Field<int>("ColorId") == customerRow.Field<int>("ColorId"))
            .Field<int>("ColorId");

        string? colorName =_colorsDataTable.AsEnumerable().FirstOrDefault(row => 
            row.Field<int>("ColorId") == colorIdentifier).Field<string>("ColorText");

        Debug.WriteLine($"Current color Id: {colorIdentifier, -4} Name: {colorName}");

    }

    private void SetCurrentColorButton_Click(object sender, EventArgs e)
    {
        DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;
        currentRow.SetField("ColorId", 4); // set to white
    }

    private void SetCurrentColorToSelectButton_Click(object sender, EventArgs e)
    {
        DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;
        currentRow.SetField("ColorId", -1); // set to Select
    }

    /// <summary>
    /// demonstrates iterating rows in the DataGridView
    /// </summary>
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
