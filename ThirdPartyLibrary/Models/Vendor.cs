namespace ThirdPartyLibrary.Models
{
    public class Vendor
    {
        public int Id { get;  }
        public string AccountNumber { get; }
        public string DisplayName { get;  }
        public int CreditRating { get;  }

        public override string ToString() => DisplayName;

        public Vendor(int id, string accountNumber, string displayName, int creditRating)
        {
            Id = id;
            AccountNumber = accountNumber;
            DisplayName = displayName;
            CreditRating = creditRating;
        }
    }
}
