namespace OwnedEntities.Models
{
    public class Order
    {
        public int Id { get; set; }
        public StreetAddress ShippingAddress { get; set; }
    }
}