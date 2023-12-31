using System;
using System.Windows.Forms;


namespace VendorsApp.Classes;

public class Dialogs
{
    public static void Information(IntPtr owner, string heading, string text, string buttonText = "Ok")
    {
            
        TaskDialogButton okayButton = new(buttonText);

        TaskDialogPage page = new()
        {
            Caption = "Information",
            SizeToContent = true,
            Heading = heading,
            Footnote = new TaskDialogFootnote() { Text = "Code sample by Karen Payne" },
            Text = text,
            Icon = new TaskDialogIcon(Helpers.BytesToIcon(Properties.Resources.blueInformation_32)),
            Buttons = [okayButton]
        };

        TaskDialog.ShowDialog(owner, page);

    }
}