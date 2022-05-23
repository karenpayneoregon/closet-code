namespace SpreadSheetLiteConsoleApp.Classes
{
    /// <summary>
    /// mutable 
    /// </summary>
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
}