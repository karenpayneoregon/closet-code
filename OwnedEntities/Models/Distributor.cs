using System.Collections.Generic;

namespace OwnedEntities.Models
{
    public class Distributor
    {
        public int Id { get; set; }
        public ICollection<StreetAddress> ShippingCenters { get; set; }
    }
}