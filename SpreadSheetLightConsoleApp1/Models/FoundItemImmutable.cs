namespace SpreadSheetLiteConsoleApp.Classes
{
    /// <summary>
    /// immutable 
    /// </summary>
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
        public override string ToString() => $"[{Column}:{RowIndex}]";
    }
}