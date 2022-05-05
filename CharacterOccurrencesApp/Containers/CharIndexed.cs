namespace StringLanguageExtensions.Containers
{
    /// <summary>
    /// For use in <see cref="General.Indexed"/>
    /// </summary>
    public class CharIndexed
    {
        /// <summary>
        /// Character
        /// </summary>
        public char Char { get; set; }
        /// <summary>
        /// Character index in string
        /// </summary>
        public int Index { get; set; }

        public override string ToString()
        {
            return $"{{ Char = {Char}, Index = {Index} }}";
        }
    }
}
