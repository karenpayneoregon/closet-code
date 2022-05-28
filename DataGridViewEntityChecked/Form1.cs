using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DataGridViewEntityChecked.Data;
using DataGridViewEntityChecked.Models;

namespace DataGridViewEntityChecked
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            using var context = new NorthwindContext();

            _bindingSource.DataSource = context.Categories.ToList();
            dataGridView1.DataSource = _bindingSource;
        }

        private void GetCheckedButton_Click(object sender, EventArgs e)
        {

            var checkedCategories =
                ((List<Categories>)_bindingSource.DataSource)
                .Where(category => category.Checked)
                .ToList();


            if (checkedCategories.Count > 0)
            {
                /*
                 * Prompt to remove selected entities
                 * Remove from database table, save
                 * if save changes is successful
                 *    Remove from BindingSource
                 * else
                 *    inform user of issues
                 */

                if (Dialogs.Question($"Remove {checkedCategories.Count} items?"))
                {
                    var (success, exception) = DataOperations.CategoriesRemoveRange(checkedCategories);
                    if (success)
                    {
                        for (int index = 0; index < checkedCategories.Count; index++)
                        {
                            _bindingSource.Remove(checkedCategories[index]);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Removal failed with\n{exception.Message}");
                    }
                }
            }
        }
    }

    public class DataOperations
    {
        public static (bool success, Exception exception) CategoriesRemoveRange(List<Categories> list)
        {
            try
            {
                // remove items here
                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }
    }
    public static class Dialogs
    {
        public static bool Question(string text)
        {
            return (MessageBox.Show(
                text,
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
