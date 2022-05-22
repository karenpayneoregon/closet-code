# About

Shows how to export data in a DataGridView regardless of if the DataSource is set or not. It was supposed to be a simple a simple code sample but once done I realized that an unsortable DataGridView was just not right so I added the SortableBindingList.

The magic

```csharp
public static void ExportRows(this DataGridView sender, string pFileName, string defaultNullValue = "(empty)")
{
    File.WriteAllLines(pFileName, sender.Rows.Cast<DataGridViewRow>()
        .Where(row => !row.IsNewRow)
        .Select(row => new RowRecord(
            row, string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                .ToArray(), cell => (cell.Value == null) ?
                defaultNullValue :
                cell.Value.ToString()))
        ))
        .Select(@row => @row.RowItem));
}
```

With

```csharp
internal record RowRecord(DataGridViewRow Row, string RowItem);
```