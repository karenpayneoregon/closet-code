﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsLibrary.Models;
using System.Text.Json;

namespace AccountsLibrary.Classes
{
    public class AccountOperations
    {
        /// <summary>
        /// File for storing accounts
        /// </summary>
        public static string FileName => "accounts.json";

        /// <summary>
        /// Calculate current balance for an <see cref="Account"/>
        /// </summary>
        /// <param name="account">Instance of an <see cref="Account"/></param>
        /// <returns>Current balance</returns>
        [DebuggerStepThrough]
        public static decimal CalculateBalance(Account account)
        {
            var deposits = account.Transactions
                .Where(transaction => transaction.TransactionType == TransactionType.Deposit)
                .Sum(transaction => transaction.Amount);
            
            var withdraws = account.Transactions
                .Where(transaction => transaction.TransactionType == TransactionType.Withdraw)
                .Sum(transaction => transaction.Amount);

            return deposits - withdraws;
        }

        /// <summary>
        /// Read all accounts from file
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static List<Account> ReadAccountsFromFile()
            => JsonSerializer.Deserialize<List<Account>>(
                File.ReadAllText(FileName));


        /// <summary>
        /// For those who forget how to serialize with indentation
        /// </summary>
        public static JsonSerializerOptions Indented
            => new() { WriteIndented = true };

        /// <summary>
        /// Get a specific account by primary key
        /// </summary>
        /// <param name="accountIdentifier"></param>
        /// <returns></returns>
        public static Account GetAccount(int accountIdentifier) 
            => ReadAccountsFromFile()
                .FirstOrDefault(account => account.AccountId == accountIdentifier);


        /// <summary>
        /// Update account after transaction(s)
        /// </summary>
        /// <param name="account">valid instance of an account</param>
        /// <remarks>
        /// TODO make a display info method
        /// </remarks>
        public static void Update(Account account)
        {
            IList<Account> list = ReadAccountsFromFile().Clone();
            
            var current = list.FirstOrDefault(x => x.AccountId == account.AccountId);

            if (current is not null)
            {
                
                if (list.Remove(current))
                {
                    list.Add(account);
                    foreach (var account1 in list.Where(x => x.AccountId == account.AccountId))
                    {
                        Console.WriteLine($"{account1.AccountId,-3}{account1.InsufficientFunds} {account1.LastName}");
                        foreach (var trans in account1.Transactions)
                        {
                            Console.WriteLine($"\t{trans.TransactionType,-15}{trans.Amount,-15}{trans.TransactionDate:d}  {trans.Description}");
                        }
                    }
                }
                
                Save(list.ToList());

            }

        }

        /// <summary>
        /// Save all accounts to file
        /// </summary>
        /// <param name="list">List of current known accounts</param>
        public static void Save(List<Account> list)
        {
            File.WriteAllText(FileName, JsonSerializer.Serialize(list, Indented));
        }

        /// <summary>
        /// Get balance of a specific account
        /// </summary>
        /// <param name="account">instance of a valid account</param>
        /// <returns>Balance for account</returns>
        public static decimal AccountBalance(Account account)
        {
            return ReadAccountsFromFile().FirstOrDefault(current => current.AccountId == account.AccountId).Balance;
        }
    }
}
