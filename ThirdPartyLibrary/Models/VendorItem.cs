namespace ThirdPartyLibrary.Models
{
    public class VendorItem
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string DisplayName { get; set; }
        public int CreditRating { get; set; }

        public override string ToString() => DisplayName;
    }
}