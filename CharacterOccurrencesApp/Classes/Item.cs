namespace CharacterOccurrencesApp.Classes
{
    public class Item
    {
        public int Index { get; set; }
        public char Character { get; set; }
        public int Occurrences { get; set; }
        public bool IsUpper { get; set; }
        public int Code { get; set; }

        #region These are all optional
        /// <summary>
        /// For debug view in local window
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Index}, {Character} - {Occurrences}";
        /// <summary>
        /// For adding items into a ListView
        /// </summary>
        public string[] ItemArray => new[] { Character.ToString(), Occurrences.ToString("D2") };

        public void Deconstruct(out char letter, out int occurrences, out int code)
        {
            letter = Character;
            occurrences = Occurrences;
            code = Code;
        }
        public void Deconstruct(out char character, out int occurrences)
        {
            character = Character;
            occurrences = Occurrences;
        }
        #endregion
    }
}