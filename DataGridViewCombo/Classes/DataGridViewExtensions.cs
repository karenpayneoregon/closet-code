using System.Windows.Forms;

namespace DataGridViewCombo1.Classes
{
    public static class DataGridViewExtensions
    {
        public static bool IsComboBoxCell(this DataGridViewCell sender)
        {
            var result = false;
            if (sender.EditType == null) return false;
            if (sender.EditType == typeof(DataGridViewComboBoxEditingControl))
            {
                result = true;
            }

            return result;
        }
    }
}
