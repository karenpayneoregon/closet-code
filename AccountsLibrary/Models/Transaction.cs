using System;

namespace AccountsLibrary.Models
{
    public class Transaction
    {
   
        public int Transaction_id { get; set; }
        public int AccountId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }


    }
}
