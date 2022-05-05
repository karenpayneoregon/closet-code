namespace CharacterOccurrencesApp.Classes
{
    public class NumberItem
    {
        public int LineNumber { get; set; }
        public int Item { get; set; }
        public int Occurrences { get; set; }

        public override string ToString() => $"{Item,-5}{Occurrences}";

    }
}