using System.Data;
using System.Reflection;

namespace SqlServerAsyncReadCore.Classes;
public static class Extensions
{
    public static int RowId(this DataRow row)
    {
        FieldInfo fieldInfo = row.GetType().GetField("_rowID",
            BindingFlags.NonPublic | BindingFlags.Instance);
        return Convert.ToInt32(fieldInfo!.GetValue(row));
    }
}
