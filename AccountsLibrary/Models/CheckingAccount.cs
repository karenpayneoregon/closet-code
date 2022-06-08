﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using AccountsLibrary.Classes;
using AccountsLibrary.Interfaces;
using AO = AccountsLibrary.Classes.AccountOperations;

namespace AccountsLibrary.Models
{
    public class CheckingAccount : ICloneable, IBaseAccount
    {
        private decimal _warningLevel;

        public event AccountBalanceWarningEvent AccountBalanceWarningEvent;
        public event AccountDenyingEvent AccountDenialEvent;

        /// <summary>
        /// Primary key
        /// </summary>
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

        public CheckingAccount()
        {
            _warningLevel = 10M;
        }

        /// <summary>
        /// Warning level is when to send an alert via our delegate
        /// </summary>
        public CheckingAccount(decimal warningLevel)
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
            transaction.TransactionId = Transactions.LastOrDefault().TransactionId + 1;
            Transactions.Add(transaction);
            
            Balance += transaction.Amount;

            if (Balance < _warningLevel && AccountBalanceWarningEvent is not null)
            {
                AccountBalanceWarningEvent?.Invoke(this, new(Number, _warningLevel, Balance));
            }

            if (Balance - transaction.Amount < 0M)
            {
                _insufficientFunds = true;
                AccountDenialEvent?.Invoke(this, new(DenialReasons.InsufficientFunds, Balance));
            }
            else
            {
                _insufficientFunds = false;
            }

            IList<CheckingAccount> list = AO.ReadAccountsFromFile().Clone();

            var current = list.FirstOrDefault(x => x.AccountId == transaction.AccountId);
            current.Transactions.Add(transaction);
            AO.Update(current);

            return Balance;

        }
        /// <summary>
        /// Withdraw from account
        /// </summary>
        public decimal Withdraw(Transaction transaction)
        {
            transaction.TransactionId = Transactions.LastOrDefault().TransactionId + 1;
            Transactions.Add(transaction);

            if (Balance - transaction.Amount < 0M)
            {
                // Deny withdraw
                _insufficientFunds = true;
                AccountDenialEvent?.Invoke(this, new(DenialReasons.InsufficientFunds, Balance));

                return Balance;
            }

            Balance -= transaction.Amount;

            AccountBalanceWarningEvent?.Invoke(this, new(Number, _warningLevel, Balance));

            return Balance;

        }
        private bool _insufficientFunds;
        private decimal _balance;
        public bool InsufficientFunds => _insufficientFunds;

        public override string ToString() => Balance.ToString("c2");
        public object Clone()
        {
            // setup
            var json = JsonSerializer.Serialize(this);

            // get
            return JsonSerializer.Deserialize<CheckingAccount>(json)!;
        }
    }
}