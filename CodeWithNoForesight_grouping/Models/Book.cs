using System.ComponentModel.DataAnnotations;

namespace CodeWithNoForesight_grouping.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => Title;
    }
}
