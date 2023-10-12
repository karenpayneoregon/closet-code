using WindowsFormsLibrary.LanguageExtensions;

namespace WinFormsApp2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.DisableControls("button1", "button3", "button4");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        this.EnableControls();
    }
}
