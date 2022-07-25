using System.ComponentModel.DataAnnotations;

namespace IsYouCodeReadable
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }
    }
}