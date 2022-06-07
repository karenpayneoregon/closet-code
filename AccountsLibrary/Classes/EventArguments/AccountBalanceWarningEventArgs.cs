using System;

// ReSharper disable once CheckNamespace
namespace AccountsLibrary.Classes
{
    public class AccountBalanceWarningEventArgs : EventArgs
    {
        private decimal Level;
        private decimal Current;
        private string mAccountNumber;

        public AccountBalanceWarningEventArgs(string Number, decimal warningLevel, decimal currentBalance)
        {
            Level = warningLevel;
            Current = currentBalance;
            mAccountNumber = Number;
        }
        public string AccountNumber => mAccountNumber;

        public decimal WarningLevel => Level;

        public decimal Balance => Current;
    }
}