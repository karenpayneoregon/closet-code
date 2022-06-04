namespace BooksLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public BookVariantId BookVariantId { get; set; }
        public BookVariant BookVariant { get; set; }
        public override string ToString() => Title;
    }
}
