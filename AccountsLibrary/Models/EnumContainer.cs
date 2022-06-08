using System;

namespace AccountsLibrary.Models
{
    /// <summary>
    /// Container for Enum member and it's description from data annotation
    /// </summary>
    public class EnumContainer
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