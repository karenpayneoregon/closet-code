using System;

namespace AccountsLibrary.Models
{
    class SavingsAccount : IBaseAccount
    {
        public decimal Balance { get; }
        public decimal Deposit(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public decimal Withdraw(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}