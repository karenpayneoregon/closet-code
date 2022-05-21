using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataGridViewCombo1.Classes;

namespace DataGridViewCombo1
{
    public partial class MainForm : Form
    {

        readonly BindingSource _customerBindingSource = new BindingSource();
        readonly BindingSource _colorBindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
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

            bindingNavigator1.BindingSource = _customerBindingSource;
            CustomersDataGridView.DataSource = _customerBindingSource;

            CustomersDataGridView.EditingControlShowing += CustomersDataGridViewOnEditingControlShowing;

            ColorIdLabel.DataBindings.Add(
                "Text", 
                _customerBindingSource, 
                "ColorId", 
                true);


        }



        // TODO
        private void CustomersDataGridViewOnEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (!CustomersDataGridView.CurrentCell.IsComboBoxCell()) return;
            if (CustomersDataGridView.Columns[CustomersDataGridView.CurrentCell.ColumnIndex].Name != nameof(ColorComboBoxColumn)) return;
            if (!(e.Control is ComboBox cb)) return;
            cb.SelectionChangeCommitted -= SelectionChangeCommitted;
            cb.SelectionChangeCommitted += SelectionChangeCommitted;
        }

        private void SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_customerBindingSource.Current != null)
            {
                if (!string.IsNullOrWhiteSpace(((DataGridViewComboBoxEditingControl)sender).Text))
                {
                    //CustomersDataGridView.EndEdit();
                    DataRow currentRow = ((DataRowView)_customerBindingSource.Current).Row;

                    ColorIdLabel.Text = currentRow.Field<int>("ColorId").ToString();
                    

                }
            }
        }

        /// <summary>
        /// access current row data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var customerRow = ((DataRowView)_customerBindingSource.Current).Row;

            var colorName = (_colorBindingSource.DataSource as DataTable).AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ColorId") == customerRow.Field<int>("ColorId"))
                .Field<string>("ColorText");
            Console.WriteLine(colorName);
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


                Console.WriteLine($"{rowIndex,-5}{productName,-15}{colorName}");

            }
        }
    }
}
