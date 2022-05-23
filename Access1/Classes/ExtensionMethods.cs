using System;
using System.Data;
using System.Text;
using Access1.Classes.BaseLibrary;

namespace Access1.Classes
{
    public static class ExtensionMethods
    {
        public static bool HasChanges(this DataTable table)
        {
            var added = table.GetChanges(DataRowState.Added);
            if (added != null)
            {
                return true;
            }

            var deleted = table.GetChanges(DataRowState.Deleted);
            if (deleted != null)
            {
                return true;
            }

            var modified = table.GetChanges(DataRowState.Modified);
            if (modified != null)
            {
                return true;
            }

            return false;
        }

    }
}