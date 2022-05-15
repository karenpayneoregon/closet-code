using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerAsyncReadCore.Classes;
using static SqlServerAsyncReadCore.Classes.CheckedListBoxExtensions;

namespace SqlServerAsyncReadCore
{
    public partial class CheckedListBoxForm : Form
    {
        public CheckedListBoxForm()
        {
            InitializeComponent();

            Shown += OnShown;
        }
        private readonly CancellationTokenSource _cancellationTokenSource = new();

        private async void OnShown(object sender, EventArgs e)
        {

            try
            {
                DataTable table = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

                ProductCheckedListBox.DataSource = table;
                ProductCheckedListBox.DisplayMember = DataOperations.DisplayColumn;
                GetCheckedButton.Enabled = table.Rows.Count > 0;
                GetCheckedProductsButton.Enabled = GetCheckedButton.Enabled;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GetCheckedButton_Click(object sender, EventArgs e)
        {
            List<CheckedData> results = ProductCheckedListBox.IndexList(DataOperations.PrimaryKey);

            if (!results.Any()) return;
            StringBuilder builder = new();

            foreach (var data in results)
            {
                builder.AppendLine($"{data.Index},{data.Identifier}, [{string.Join(",", data.Row.ItemArray)}]");
            }

            textBox1.Text = builder.ToString();

        }

        private void GetCheckedProductsButton_Click(object sender, EventArgs e)
        {
            List<ProductItem> results =
                ProductCheckedListBox.ProductSelectedList(DataOperations.PrimaryKey);

            if (!results.Any()) return;
            StringBuilder builder = new();

            foreach (var item in results)
            {
                builder.AppendLine($"{item.Identifier}, {item.ProductName}");
            }

            textBox1.Text = builder.ToString();

        }


        private async void HardWiredWhereInButton_Click(object sender, EventArgs e)
        {
            var (exception, success, list) = await SqlOperations.ReadPlaceholderTask(_cancellationTokenSource.Token);
            if (success)
            {
                foreach (var name in list)
                {
                    Debug.WriteLine(name);
                }
            }
        }


    }
}
