using DataGridViewExport.Models;

namespace DataGridViewExport;
public partial class EditForm : Form
{
    public readonly Contact _contact;

    public EditForm()
    {
        InitializeComponent();

    }
    
    public EditForm(object contact)
    {
        InitializeComponent();

        _contact = contact as Contact;
        FirstNameTextBox.DataBindings.Add("Text", _contact, nameof(Contact.FirstName));
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        _contact.FirstName = FirstNameTextBox.Text;
        DialogResult = DialogResult.OK;
    }
}
