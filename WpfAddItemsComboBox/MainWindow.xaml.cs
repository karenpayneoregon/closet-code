using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAddItemsComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ExampleComboBox.ItemsSource = new List<Category>()
            {
                new Category() {Id = 1, Name = "Meat"}, 
                new Category() { Id = 2, Name = "Fruit" }
            };
            ExampleComboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = (List<Category>)ExampleComboBox.ItemsSource;
            list.Add(new Category() { Id = 3, Name = "Fish" });
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;

    }
}
