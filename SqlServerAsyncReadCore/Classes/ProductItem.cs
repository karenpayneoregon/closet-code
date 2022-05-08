namespace SqlServerAsyncReadCore.Classes
{
    public static partial class CheckedListBoxExtensions
    {
        public class ProductItem    
        {
            public int Identifier { get; set; }
            public string ProductName { get; set; }
            public int Index { get; set; }
            public override string ToString() => ProductName;
        }
    }
}