using System.Data;

namespace SqlServerAsyncReadCore.Classes
{
    public static partial class CheckedListBoxExtensions
    {
        public class CheckedData
        {
            /// <summary>
            /// Associated data row for the checked item
            /// </summary>
            public DataRow Row { get; set; }
            /// <summary>
            /// Item index in the CheckedListBox
            /// </summary>
            public int Index { get; set; }
            /// <summary>
            /// Primary key for Row property
            /// </summary>
            public int Identifier { get; set; }
        }
    }
}