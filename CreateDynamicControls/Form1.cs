using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CreateDynamicControls.Classes;
using CreateDynamicControls.Classes.Containers;
using CreateDynamicControls.Classes.Controls;
using CreateDynamicControls.Properties;

namespace CreateDynamicControls
{
    public partial class Form1 : Form
    {
        private BindingList<Product> _productsBindingList;
        private readonly BindingSource _productBindingSource = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();

            /*
             * This could also be part of Operations.Initialize
             */
            Operations.BaseName = "CategoryButton";
            
            Operations.Initialize(this,20,30, 10,100, CategoryButtonClick);
            
            ProductsListBox.DoubleClick += ProductsListBoxOnDoubleClick;

        }
        /// <summary>
        /// Access current product id and name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsListBoxOnDoubleClick(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is null)
            {
                return;
            }

            var product = (Product) _productBindingSource.Current;

            MessageBox.Show($"{product.Id}, {product.Name}");
        }
        /// <summary>
        /// Prefix of button name is going to be CategoryButton so that it works
        /// with the SQL-Server button creation, to change the base name
        ///
        /// Operations.BaseName = "Button";
        ///
        /// Where Button can be what you want.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButtonClick(object sender, EventArgs e)
        {
            
            Operations.CreateButton(string.IsNullOrWhiteSpace(ButtonTextButton.Text) ? "(empty)" : ButtonTextButton.Text);
            
        }

        private void GenericButtonClick(object sender, EventArgs e)
        {
            var button = (Button) sender;
            MessageBox.Show(button.Name);
        }
        
        private void CategoryButtonClick(object sender, EventArgs e)
        {
            Operations.ButtonsList.ForEach(b => b.Image = null);

            var button = (DataButton)sender;
            button.Image = Resources.CheckDot_6x_16x;
            
            _productsBindingList = new BindingList<Product>(DataOperations.ReadProducts(button.Identifier));
            _productBindingSource.DataSource = _productsBindingList;
            ProductsListBox.DataSource = _productBindingSource;

        }

        private void ButtonListButton_Click(object sender, EventArgs e)
        {
            ButtonsListBox.DataSource = Operations.ButtonsList.Select(button => button.Name).ToList();
        }
        /// <summary>
        /// Requires SQL-Server and to run the script under DataScripts folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCategoriesButton_Click(object sender, EventArgs e)
        {
            // don't want to repeat this operation
            CreateCategoriesButton.Enabled = false;
            foreach (var category in DataOperations.ReadCategories())
            {
                Operations.CreateCategoryButton(category.Name, category.Id);
            }
            
        }
    }


}
