using System.Windows.Forms;

namespace DataGridViewEntityChecked.Classes
{
    public static class Dialogs
    {
        public static bool Question(string text)
        {
            return (MessageBox.Show(
                text,
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}