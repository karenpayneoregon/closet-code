using System;
using AccountsLibrary.Models;

// ReSharper disable once CheckNamespace
namespace AccountsLibrary.Classes
{
    public class AccountDenialEventArgs : EventArgs
    {
        public AccountDenialEventArgs(DenialReasons reason, decimal balance)
        {
            Reason = reason;
            Balance = balance;
        }

        public DenialReasons Reason { get; }
        public decimal Balance { get; set; }
    }


}