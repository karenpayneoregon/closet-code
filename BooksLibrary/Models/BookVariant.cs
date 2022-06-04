using System.Collections.Generic;

namespace BooksLibrary.Models
{
    public class BookVariant
    {
        public BookVariantId BookVariantId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public override string ToString() => Name;
    }
}