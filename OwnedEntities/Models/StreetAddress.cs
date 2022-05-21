using Microsoft.EntityFrameworkCore;

namespace OwnedEntities.Models
{
    [Owned]
    public class StreetAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}