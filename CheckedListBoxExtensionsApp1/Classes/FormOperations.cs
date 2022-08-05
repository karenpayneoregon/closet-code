using System.Drawing;
using System.Windows.Forms;
using CheckedListBoxExtensionsApp1.Extensions;

namespace CheckedListBoxExtensionsApp1.Classes
{
    public static class FormOperations
    {
        public static void StyleForm(this Form f)
        {

            f.BackColor = Color.FromArgb(225, 225, 225);
            f.Font = new Font("Microsoft Sans Serif", 10);

            foreach (Control control in f.Descendants<Control>())
            {
                switch (control)
                {
                    case StatusStrip strip:
                        strip.BackColor = Color.FromArgb(93, 107, 153);
                        strip.Font = new Font("Microsoft Sans Serif", 10);
                        break;
                    case MenuStrip menuStrip:
                        menuStrip.Font = new Font("Microsoft Sans Serif", 10);
                        break;
                    case DataGridView view:
                        view.RowHeadersVisible = false;
                        view.DefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 213, 255);
                        view.GridColor = Color.Red;
                        break;
                }
            }
        }
    }
}
