using System.Text.Json;

namespace CommonLibrary.Classes
{
    public class JsonHelpers
    {
        /// <summary>
        /// For those who forget how to serialize with indentation
        /// </summary>
        public JsonSerializerOptions Indented 
            => new() { WriteIndented = true, };
    }
}
