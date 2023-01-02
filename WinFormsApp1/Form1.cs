using WinFormsApp1.Classes;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Shown += OnShown;
    }

    private void OnShown(object? sender, EventArgs e)
    {
        CategoryComboBox.DataSource = DataOperations.Categories();
    }

    private void CurrentSelectionButton_Click(object sender, EventArgs e)
    {
        var category = (Category)CategoryComboBox.SelectedItem;
        MessageBox.Show($"{category.Id} {category.Name}");
    }
}
