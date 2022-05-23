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
        public static TableChanges AllChanges(this DataTable dataTable, int primaryKeyIndex)
        {
            var results = new TableChanges { Deleted = dataTable.GetChanges(DataRowState.Deleted) };

            results.HasDeleted = results.Deleted != null;

            for (var index = 0; index < dataTable.Rows.Count; index++)
            {
                if (dataTable.Rows[index].RowState == DataRowState.Deleted)
                {
                    results.DeletedPrimaryKeys.Add(Convert.ToInt32(dataTable.Rows[index][primaryKeyIndex,
                        DataRowVersion.Original]));
                }
            }

            results.Modified = dataTable.GetChanges(DataRowState.Modified);
            results.HasModified = results.Modified != null;

            results.Added = dataTable.GetChanges(DataRowState.Added);
            results.HasNew = results.Added != null;

            results.UnChanged = dataTable.GetChanges(DataRowState.Unchanged);
            results.HasUnchanged = results.UnChanged != null;

            results.Any = results.HasDeleted || results.HasModified || results.HasNew;

            return results;

        }
        /// <summary> 
        /// Get changes by primary name 
        /// </summary> 
        /// <param name="dataTable"></param> 
        /// <param name="primaryKeyColumnName"></param> 
        /// <returns></returns> 
        public static TableChanges AllChanges(this DataTable dataTable, string primaryKeyColumnName = "id")
        {

            int primaryKeyIndex = dataTable.Columns[primaryKeyColumnName].Ordinal;
            var results = dataTable.AllChanges(primaryKeyIndex);

            return results;

        }
        /// <summary> 
        /// Returns a comma delimited string representing all  
        /// data rows in the table. 
        /// </summary> 
        /// <param name="dataTable"></param> 
        /// <returns></returns> 
        public static string Flatten(this DataTable dataTable)
        {
            var sb = new StringBuilder();

            foreach (DataRow row in dataTable.Rows)
            {
                sb.AppendLine(string.Join(",", row.ItemArray));
            }

            return sb.ToString();

        }
    }
}