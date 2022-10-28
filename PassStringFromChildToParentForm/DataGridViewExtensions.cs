using System.Linq;
using System.Windows.Forms;

namespace PassStringFromChildToParentForm
{
    public static class DataGridViewExtensions
    {
        // in this case the cell is assumed to be 0, change if not 0
        public static bool MonthNotExists(this DataGridView dgv, string month) => 
            dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[0].Value.ToString()
                    .Equals(month)) == null;
    }
}