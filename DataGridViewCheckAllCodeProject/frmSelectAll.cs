using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SelectAll.Classes;

namespace SelectAll
{
    public partial class frmSelectAll : Form
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        public frmSelectAll()
        {
            InitializeComponent();
        }

        private void frmSelectAll_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += HeaderCheckBox_KeyUp;
            HeaderCheckBox.MouseClick += HeaderCheckBox_MouseClick;
            dgvSelectAll.CellValueChanged += dgvSelectAll_CellValueChanged;
            dgvSelectAll.CurrentCellDirtyStateChanged += dgvSelectAll_CurrentCellDirtyStateChanged;
            dgvSelectAll.CellPainting += dgvSelectAll_CellPainting;

            BindGridView();
        }

        private readonly BindingSource _bindingSource = new BindingSource();
        private void BindGridView()
        {
            _bindingSource.DataSource = GetDataSource();
            dgvSelectAll.DataSource = _bindingSource;

            TotalCheckBoxes = dgvSelectAll.RowCount;
            TotalCheckedCheckBoxes = 0;
        }

        private DataTable GetDataSource()
        {
            var dTable = new DataTable();

            dTable.Columns.Add("IsChecked", typeof(bool));
            dTable.Columns.Add("RandomNo");
            dTable.Columns.Add("Date", typeof(DateTime));
            dTable.Columns.Add("Time", typeof(DateTime));
            dTable.Columns.Add(new DataColumn() { ColumnName = "id", AutoIncrement = true, AutoIncrementSeed = 1, ColumnMapping = MappingType.Hidden});
            var data = BogusOperations.Items();

            for (int index = 0; index < 10; ++index)
            {
                var dRow = dTable.NewRow();

                dRow["IsChecked"] = "false";
                dRow["RandomNo"] = data[index].RandomNo; 
                dRow["Date"] = data[index].Date;
                dRow["Time"] = data[index].Date;

                dTable.Rows.Add(dRow);
                dTable.AcceptChanges();
            }

            return dTable;
        }

        private void dgvSelectAll_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
            {
                RowCheckBoxClick((DataGridViewCheckBoxCell)dgvSelectAll[e.ColumnIndex, e.RowIndex]);
            }
        }

        private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSelectAll.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvSelectAll.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }

        private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
            }
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            //Add the CheckBox into the DataGridView
            dgvSelectAll.Controls.Add(HeaderCheckBox);
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = dgvSelectAll.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point
            {
                X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1,
                Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1
            };

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvSelectAll.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["chkBxSelect"]).Value = HCheckBox.Checked;
            }

            dgvSelectAll.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modify Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }

        private void GetCheckedButton_Click(object sender, EventArgs e)
        {
            var table = (DataTable)_bindingSource.DataSource;
            var checkedItems = table.AsEnumerable().Where(row => row.Field<bool>("IsChecked")).ToList();
            if (checkedItems.Count >0)
            {
                foreach (var row in checkedItems)
                {
                    Console.WriteLine(row.Field<int>("id"));
                }
            }
            else
            {
                MessageBox.Show("Nothing checked");
            }
        }
    }
}
