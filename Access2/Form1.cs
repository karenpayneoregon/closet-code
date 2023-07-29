using System.Data;

namespace Access2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        var (success, identifier) = DataOperations.InsertRow("Frank", "Smith");
        if (success)
        {
            // identifier has the new primary key
        }
        else
        {
            // failed
        }
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        var result = DataOperations.UpdateRow(3, "Karen", "Smith");
        if (result)
        {
            // updated
        }
        else
        {
            // failed
        }
    }

    private void ReadButton_Click(object sender, EventArgs e)
    {
        DataTable table = DataOperations.GetAll();
    }
}
