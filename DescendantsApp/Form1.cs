using System.Diagnostics;
using WindowsFormsLibrary.LanguageExtensions;

namespace DescendantsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // get all controls on the form and in child controls.
        List<Control> allDescendants = this.Descendants<Control>().ToList();
        // only get buttons
        List<Button> onlyButtons = this.ButtonList();
    }

    // get first and second level controls
    private void button2_Click(object sender, EventArgs e)
    {
        // get all controls on the form and in child controls.
        var allDescendants = this.Descendants<Control>().ToList();
        foreach (var control in allDescendants)
        {
            if (control.Parent == this)
            {
                Debug.WriteLine($"Control on parent: {control.Name}");
                var children = control.Descendants<Control>().ToList();
                if (children.Count > 0)
                {
                    Debug.WriteLine("  Children");
                    foreach (var child in children)
                    {
                        Debug.WriteLine($"    {child.Name}");
                    }
                }
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        List<Control> controlsDirectlyOnParent = this.ParentLevelOnly();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var buttonsOnPanelControls = panel1.Descendants<Button>();
        var panelControls = panel1.Descendants<Control>();
    }
}
