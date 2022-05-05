using System;

namespace EnumerationLibrary.Classes
{
    public class ItemContainer
    {
        /// <summary>
        /// Display text
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Underlying enum
        /// </summary>
        public Enum Value { get; set; }
    }
}