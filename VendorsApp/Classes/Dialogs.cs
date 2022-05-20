using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VendorsApp.Classes
{
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
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };

            TaskDialog.ShowDialog(owner, page);

        }
    }
}
