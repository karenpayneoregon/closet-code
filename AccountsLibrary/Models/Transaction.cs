using System;

namespace AccountsLibrary.Models
{
    /// <summary>
    /// Container for an Account transaction e.g. deposit, withdraw
    /// </summary>
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public override string ToString() => $"{AccountId,-4}{TransactionId,-4}{TransactionType}";



    }
}
