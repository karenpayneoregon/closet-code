using FastMember;
using System.Data;

namespace DataGridViewLibrary;
public class CommonHelpers
{
    public static DataTable ToDataTable<T>(List<T> sender)
    {
        DataTable table = new();
        using var reader = ObjectReader.Create(sender);
        table.Load(reader);

        return table;
    }
}
