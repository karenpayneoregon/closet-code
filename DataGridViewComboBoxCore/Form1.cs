using DataGridViewComboBoxCore.Classes;
using DataGridViewComboBoxCore.Extensions;
using System.Data;
using System.Diagnostics;
using static DataGridViewComboBoxCore.Classes.Dialogs;

// ReSharper disable LocalizableElement

namespace DataGridViewComboBoxCore;

public partial class Form1 : Form
{
    private readonly BindingSource _mainBindingSource = new();
    private readonly BindingSource _comboBoxBindingSource = new();

    private DataTable _colorsDataTable;
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
        toolStripButtonAbout.Click += ToolStripButton1_Click;
    }

    private void ToolStripButton1_Click(object? sender, EventArgs e)
    {
        Information(this,"Code sample by Karen Payne");
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {
        Setup();
        ProductsDataGridView.AllowUserToAddRows = false;
    }

    private void Setup()
    {

        ProductsDataGridView.AutoGenerateColumns = false;

        var (productsTable, colorTable) = ProductOperations.LoadData();

        _colorsDataTable = colorTable;
        _comboBoxBindingSource.DataSource = colorTable;

        ColorComboBoxColumn.DisplayMember = "ColorText";
        ColorComboBoxColumn.ValueMember = "ColorId";
        ColorComboBoxColumn.DataPropertyName = "ColorId";

        ColorComboBoxColumn.DataSource = _comboBoxBindingSource;

        ColorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

        ItemTextBoxColumn.DataPropertyName = "Item";
        _mainBindingSource.DataSource = productsTable;

        coreBindingNavigator1.BindingSource = _mainBindingSource;
        coreBindingNavigator1.DisableAddNewItems();
        coreBindingNavigator1.DisableRemoveItems();

        ProductsDataGridView.DataSource = _mainBindingSource;

        productsTable.RowChanged += ProductsTable_RowChanged;
    }
    /// <summary>
    /// Update current row on leave row
    /// - If ColorId = -1 abort
    /// - If Item is empty so be it, feel free to add assertion
    ///   as Item column is setup as null is permitted.
    /// </summary>
    /// <remarks>
    /// For more on DataTable events see my GitHub repository
    /// https://github.com/karenpayneoregon/DataTablesOperationsEvents
    /// </remarks>
    private void ProductsTable_RowChanged(object sender, DataRowChangeEventArgs e)
    {
        
        if (e.Action == DataRowAction.Change)
        {
            if (e.Row.Field<int>("ColorId") == -1)
            {
                // no color selected
                return;
            }
            var (success, exception) = ProductOperations.UpdateRow(e.Row);
            if (!success)
            {
                // should really write to a log file and not show the exception
                MessageBox.Show($"Failed to update\n{exception.Message}");
            }
        }
    }




    /// <summary>
    /// Code to get at the current DataGridView row
    /// </summary>
    private void CurrentButton_Click(object sender, EventArgs e)
    {
        DataRow currentRow = _mainBindingSource.DataRow();
        
        int colorIdentifier = _comboBoxBindingSource.DataTable().AsEnumerable()
            .FirstOrDefault(row => row.Field<int>("ColorId") == currentRow.Field<int>("ColorId"))
            .Field<int>("ColorId");

        string? colorName =_colorsDataTable.AsEnumerable().FirstOrDefault(row => 
            row.Field<int>("ColorId") == colorIdentifier).Field<string>("ColorText");

        Debug.WriteLine($"Current color Id: {colorIdentifier, -4} Name: {colorName}");

    }

    private void SetCurrentColorButton_Click(object sender, EventArgs e)
    {
        DataRow currentRow = _mainBindingSource.DataRow();
        currentRow.SetField("ColorId", 4); // set to white
    }

    private void SetCurrentColorToSelectButton_Click(object sender, EventArgs e)
    {
        DataRow currentRow = _mainBindingSource.DataRow();
        currentRow.SetField("ColorId", -1); // set to Select
    }

    /// <summary>
    /// demonstrates iterating rows in the DataGridView
    /// </summary>
    private void IterateRowsButton_Click(object sender, EventArgs e)
    {
        DataTable productTable = _mainBindingSource.DataTable();
        DataTable colorTable = _comboBoxBindingSource.DataTable(); ;

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
