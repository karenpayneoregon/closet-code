using System.Collections.Generic;
using AccountsLibrary.Classes;
using AO = AccountsLibrary.Classes.AccountOperations;

namespace AccountsLibrary.Models
{
    public class Account
    {
        private decimal _warningLevel;

        public event AccountBalanceWarningEventHandler AccountBalanceWarningEvent;
        public event AccountDenyingEventHandler AccountDenialEvent;

        public int AccountId { get; set; }
        /// <summary>
        /// Account number alpha numeric
        /// </summary>
        public string Number { get; set; }

        public string UserName { get; set; }
        public string PIN { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Transaction> Transactions { get; set; } = new();

        public Account()
        {
            _warningLevel = 10M;
        }

        /// <summary>
        /// Warning level is when to send an alert via our delegate
        /// </summary>
        public Account(decimal warningLevel)
        {
            _warningLevel = warningLevel;
            _insufficientFunds = Balance <= 0M;
        }

        /// <summary>
        /// Current balance of account
        /// </summary>
        /// <remarks>Read-only</remarks>
        public decimal Balance
        {
            get
            {
                _balance = AO.CalculateBalance(this);
                return _balance;

            }

            private set => _balance = value;

        }

        /// <summary>
        /// Deposit money into account
        /// </summary>
        public decimal Deposit(Transaction transaction)
        {
            Transactions.Add(transaction);

            Balance += transaction.Amount;

            if (Balance < _warningLevel && AccountBalanceWarningEvent is not null)
            {
                AccountBalanceWarningEvent?.Invoke(
                    this,
                    new(Number, _warningLevel, Balance));
            }

            if (Balance - transaction.Amount < 0M)
            {
                _insufficientFunds = true;
                AccountDenialEvent?.Invoke(
                    this,
                    new(DenialReasons.InsufficientFunds));
            }
            else
            {
                _insufficientFunds = false;
            }

            return Balance;

        }
        /// <summary>
        /// Withdraw from account
        /// </summary>
        public decimal Withdraw(Transaction transaction)
        {
            Transactions.Add(transaction);

            if (Balance - transaction.Amount < 0M)
            {
                // Deny withdraw
                _insufficientFunds = true;
                AccountDenialEvent?.Invoke(
                    this,
                    new(DenialReasons.InsufficientFunds));

                return Balance;
            }

            Balance -= transaction.Amount;

            AccountBalanceWarningEvent?.Invoke(
                this,
                new(Number, _warningLevel, Balance));

            return Balance;

        }
        private bool _insufficientFunds;
        private decimal _balance;
        public bool InsufficientFunds => _insufficientFunds;

        public override string ToString() => Balance.ToString("c2");
    }
}