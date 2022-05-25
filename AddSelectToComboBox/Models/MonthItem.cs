namespace AddSelectToComboBox.Models
{
    public class MonthItem
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}