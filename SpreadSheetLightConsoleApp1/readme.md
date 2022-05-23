# About

Objective is to properly select the proper type for a specific operation. In this case the business requirement is to allow a user to find specific text in an Excel work sheet. A method searches all used cells, when the text is located the cell address is placed into a list.

**Options one**

This class provides properties for remembering cell addresses but can be changed after returned from the method. There is no reason to allow changing the list once returned so this method even though simple does not work as it’s mutable. If requirements were to allow changing data then this is fine.

```csharp
public class FoundItem
{
    public int RowIndex { get; set; }
    public string Column { get; set; }
    public int ColumnIndex { get; set; }
    public override string ToString()
    {
        return $"[{Column}:{RowIndex}]";
    }
}
```

**Options two**

This class provides properties to remember cell addresses but does not allow modifications to the list or items in the list, this is known as immutable and is a better choice. 

```csharp

public class FoundItemImmutable
{
    public int RowIndex { get; init; }
    public string Column { get; init; }
    public int ColumnIndex { get; init; }

    public FoundItemImmutable(int rowIndex, int columnIndex, string column)
    {
        RowIndex = rowIndex;
        ColumnIndex = columnIndex;
        Column = column;

    }
    public override string ToString()
    {
        return $"[{Column}:{RowIndex}]";
    }
}
```

# Conclusion

Most novice developer will use option one not considering the mutable aspect that allows items to be changed and also is easier to implement which is not a valid reason to use a mutable list and not consider the caller of the method will not pollute data.

Never select a type simply because it’s easy to implement.