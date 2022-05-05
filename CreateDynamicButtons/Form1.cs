using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateDynamicButtons.Classes;
using CreateDynamicButtons.Containers;
using CreateDynamicButtons.Properties;
using WindowsControlLibrary.Classes;

namespace CreateDynamicButtons
{
    public partial class Form1 : Form
    {
        private BindingList<Product> _productsBindingList;
        private readonly BindingSource _productBindingSource = new ();

        public Form1()
        {
            InitializeComponent();

            // initialize button options
            ButtonOperations.BaseName = "CategoryButton";
            ButtonOperations.Initialize(this, 20, 30, 10, 100, CategoryButtonClick);

            Shown += OnShown;
        }

        /// <summary>
        /// Create buttons from database
        /// </summary>
        private void OnShown(object sender, EventArgs e)
        {
            foreach (var category in DataOperations.ReadCategories())
            {
                ButtonOperations.CreateCategoryButton(category.Name, category.Id);
            }
        }

        /// <summary>
        /// Show data, mark button with image to show where we are
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryButtonClick(object sender, EventArgs e)
        {
            ButtonOperations.ButtonsList.ForEach(b => b.Image = null);

            var button = (DataButton)sender;
            button.Image = Resources.CheckDot_6x_16x;

            _productsBindingList = new BindingList<Product>(DataOperations.ReadProducts(button.Identifier));

            _productBindingSource.DataSource = _productsBindingList;
            ProductsListBox.DataSource = _productBindingSource;

        }
    }
}
