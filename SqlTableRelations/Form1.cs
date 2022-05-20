using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerOperations;
using SqlServerOperations.Classes;

namespace SqlTableRelations
{
    public partial class Form1 : Form
    {
        private readonly SqlInformation _tableInformation = new SqlInformation();

        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;

            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;
        }
        /// <summary>
        /// Set description text box with (if present) the description for the
        /// current column.
        ///
        /// Note: if (e.IsSelected) prevents a common issue with developers of
        /// a double trigger of the ItemSelectionChanged change event where one
        /// time the item is not the selected item even though it will be the
        /// selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                DescriptionTextBox.Text = e.Item.Tag.ToString();
            }
            
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                var items = _tableInformation.TableDependencies();
                tableInformationComboBox.DataSource = new BindingSource(items, null);
                tableInformationComboBox.DisplayMember = "Key";
            }
            catch (Exception localException)
            {
                GetInformationButton.Enabled = false;

                MessageBox.Show($@"Failed to read database
{localException.Message}");
            }

        }
        /// <summary>
        /// Retrieve column details for selected table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetInformationButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var detailItems = ((KeyValuePair<string, List<ServerTableItem> >)
                tableInformationComboBox.SelectedItem);

            foreach (var serverTableItem in detailItems.Value)
            {
                var item = listView1.Items.Add(serverTableItem.FieldOrder.ToString());
                item.SubItems.Add(serverTableItem.Field);
                item.SubItems.Add(serverTableItem.DataType);
                item.SubItems.Add(serverTableItem.Length.ToString());
                item.SubItems.Add(serverTableItem.Precision);
                item.SubItems.Add(serverTableItem.Scale.ToString());
                item.SubItems.Add(serverTableItem.AllowNulls);
                item.SubItems.Add(serverTableItem.Identity);
                item.SubItems.Add(serverTableItem.PrimaryKey);
                item.SubItems.Add(serverTableItem.ForeignKey);
                item.SubItems.Add(serverTableItem.RelatedTable);

                item.Tag = serverTableItem.Description;
            }
      
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.FocusedItem = listView1.Items[0];
            listView1.Items[0].Selected = true;
            ActiveControl = listView1;

            /*
             * Shade alternate rows
             */
            var index = 0;
            var shadedBackgroundColor = Color.FromArgb(240, 240, 240);

            foreach (ListViewItem item in listView1.Items)
            {
                if (index++ % 2 != 1) continue;
                item.BackColor = shadedBackgroundColor;
                item.UseItemStyleForSubItems = true;
            }
        }
    }
}
