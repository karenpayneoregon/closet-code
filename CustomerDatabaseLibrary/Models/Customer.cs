using System.ComponentModel.DataAnnotations;

namespace CustomerDatabaseLibrary.Models
{
    public class Customer
    {
        public int Identifier { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public int? ContactTypeIdentifier { get; set; }
        [Required]
        public int? GenderIdentifier { get; set; }
        public override string ToString() => CompanyName;
    }
}
