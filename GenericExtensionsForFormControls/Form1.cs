using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericExtensionsForFormControls.Classes;
using GenericExtensionsForFormControls.Extensions;
using GenericExtensionsForFormControls.Models;

namespace GenericExtensionsForFormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CategoryListBox.DataSource = JsonOperations.Categories();
            ProductListBox.DataSource = JsonOperations.Products();
        }

        /// <summary>
        /// Here we are locked into a specific model while
        /// the event below is generic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentCategoryIBaseButton_Click(object sender, EventArgs e)
        {
            var (text, category) = CategoryListBox.CurrentCategory();
            MessageBox.Show($"{category.Id,-3}{text}");
        }

        /// <summary>
        /// Here we are generic as opposed to above
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentCategoryGenericButton_Click(object sender, EventArgs e)
        {
            var (text, category) = CategoryListBox.Current<Category>();
            MessageBox.Show($"{category.Id,-3}{text}");
        }

        private void CurrentCategoryCommonButton_Click(object sender, EventArgs e)
        {
            Category category = CategoryListBox.SelectedItem as Category;
            MessageBox.Show($"{category.Id, -3}{category.Name}");
        }

        private void CurrentProductIBaseButton_Click(object sender, EventArgs e)
        {
            var (text, product) = ProductListBox.CurrentProduct();
            MessageBox.Show($"{product.Id,-3}{text}");
        }

        private void CurrentProductGeneric_Click(object sender, EventArgs e)
        {
            var (text, product) = ProductListBox.Current<Product>();
            MessageBox.Show($"{product.Id,-3}{text}");
        }
        private void ProductCommonButton_Click(object sender, EventArgs e)
        {
            var product = ProductListBox.SelectedItem as Product;
            MessageBox.Show($"{product.Id,-3}{product.Name}");
        }

    }
}
