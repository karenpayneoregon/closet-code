using System;
using System.Collections.Generic;
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
        public static string FileName => "accounts.json";

        /// <summary>
        /// Calculate current balance for an <see cref="Account"/>
        /// </summary>
        /// <param name="account">Instance of an <see cref="Account"/></param>
        /// <returns>Current balance</returns>
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

        public static List<Account> Accounts()
            => JsonSerializer.Deserialize<List<Account>>(
                File.ReadAllText(FileName));

        public static Account GetAccount(int accountIdentifier) 
            => Accounts()
                .FirstOrDefault(account => account.AccountId == accountIdentifier);

        /// <summary>
        /// Update account after transaction(s)
        /// </summary>
        /// <param name="account">valid instance of an account</param>
        public static void Update(Account account)
        {
            // TODO
        }
    }
}
