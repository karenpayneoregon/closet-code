using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AccountsLibrary.Classes;
using AccountsLibrary.Models;

namespace AccountsLibraryUnitTestProject.Base
{
    /// <summary>
    /// Responsible for creating account json file
    /// </summary>
    public class MockOperations
    {

        public static CheckingAccount MyAccount()
        {
            CheckingAccount account = new()
            {
                AccountId = 1,
                FirstName = "Karen",
                LastName = "Payne",
                UserName = "KarenPayne",
                Number = "KP100"
            };

            account.Deposit(new Transaction()
            {
                AccountId = 1,
                TransactionId = 1,
                TransactionType = TransactionType.Deposit,
                Amount = 1000,
                Description = "First deposit",
                TransactionDate = new DateTime(2022, 1, 12)
            });

            account.Deposit(new Transaction()
            {
                AccountId = 1,
                TransactionId = 2,
                TransactionType = TransactionType.Deposit,
                Amount = 150,
                Description = "Second deposit",
                TransactionDate = new DateTime(2022, 2, 6)
            });

            account.Deposit(new Transaction()
            {
                AccountId = 1,
                TransactionId = 3,
                TransactionType = TransactionType.Deposit,
                Amount = 1800,
                Description = "Third deposit",
                TransactionDate = new DateTime(2022, 3, 22)
            });

            account.Withdraw(new Transaction()
            {
                AccountId = 1,
                TransactionId = 3,
                TransactionType = TransactionType.Withdraw,
                Amount = 50,
                Description = "First withdraw",
                TransactionDate = new DateTime(2022, 4, 15)
            });


            return account;

        }
        public static CheckingAccount OtherAccount()
        {
            CheckingAccount account = new()
            {
                AccountId = 2,
                FirstName = "Mike",
                LastName = "Adams",
                UserName = "MikeAdams",
                Number = "MA100"
            };

            
            account.Deposit(new Transaction()
            {
                AccountId = 2,
                TransactionId = 1,
                TransactionType = TransactionType.Deposit,
                Amount = 2000,
                Description = "First deposit",
                TransactionDate = new DateTime(2022, 5, 2)
            });

            account.Deposit(new Transaction()
            {
                AccountId = 2,
                TransactionId = 2,
                TransactionType = TransactionType.Deposit,
                Amount = 100,
                Description = "Second deposit",
                TransactionDate = new DateTime(2022, 5, 8)
            });


            return account;
        }

        public static void AccountToJsonFile()
        {
            List<CheckingAccount> accounts = new List<CheckingAccount>()
            {
                MyAccount(),
                OtherAccount()
            };

            File.WriteAllText(AccountOperations.FileName,
                JsonSerializer.Serialize(accounts,
                    new JsonSerializerOptions { WriteIndented = true, }));
        }

        /// <summary>
        /// Determine if account json file exists
        /// </summary>
        public static bool AccountFileDoesNotExists =>
            !File.Exists(AccountOperations.FileName);
    }
}
