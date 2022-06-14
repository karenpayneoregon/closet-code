using System;
using System.Collections.Generic;
using System.Linq;
using AccountsLibrary;
using AccountsLibrary.Classes;
using AccountsLibrary.Models;
using AccountsLibraryUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using AO = AccountsLibrary.Classes.AccountOperations;

namespace AccountsLibraryUnitTestProject
{
    [TestClass]
    public partial class CheckingAccountTest : TestBase
    {


        [TestMethod]
        [TestTraits(Trait.Banking)]
        public void AccountExistsTest()
        {
            // arrange
            int accountId = 1;

            // act
            var account = AO.GetAccount(accountId);

            // assert
            Check.That(account).IsNotNull();

        }

        [TestMethod]
        [TestTraits(Trait.Banking)]
        public void AccountDoesNotExistsTest()
        {
            // arrange
            int accountId = 22;

            // act
            var account = AO.GetAccount(accountId);

            // assert
            Check.That(account).IsNull();
        }

        [TestMethod]
        [TestTraits(Trait.Banking)]
        public void ValidateFirstBalance()
        {
            // arrange
            int accountId = 1;
            decimal balance = 2900;

            // act
            var account = AO.GetAccount(accountId);
            
            // assert
            Check.That(account.Balance).Equals(balance);
        }

        [TestMethod]
        [TestTraits(Trait.Banking)]
        public void NegativeBalance()
        {
            // arrange
            int accountId = 1;
            decimal balance = 2900;

            // act
            var account = AO.GetAccount(accountId);
            Console.WriteLine($"Checking funds: {account.InsufficientFunds}");
            account.AccountDenial += OnAccountDenial;

            account.Withdraw(new Transaction()
            {
                AccountId = 1, 
                Amount = balance +100, 
                TransactionType = TransactionType.Withdraw, 
                TransactionDate = DateTime.Now,
                Description = "Need money fast"
            });

            account.AccountDenial -= OnAccountDenial;
            AO.Update(account);
            Check.That(account.Balance).Equals(-100);

            account.Deposit(new Transaction()
            {
                AccountId = 1,
                Amount = 2000,
                TransactionType = TransactionType.Deposit,
                TransactionDate = DateTime.Now,
                Description = "Some deposit"
            });

            Check.That(account.Balance).Equals(AO.AccountBalance(account));

        }

        /// <summary>
        /// View for teller or ATM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAccountDenial(object sender, AccountDenialEventArgs e)
        {

            var reason = EnumHelpers
                .GetEnumDetails<DenialReasons>()
                .FirstOrDefault(item => Equals(item.Value, e.Reason))
                .Description;

            Console.WriteLine(
                $"Alert: withdraw denied, {reason} with a balance of {e.Balance:C}");

        }

        
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void ViewData()
        {
            AO.ViewAccounts();
        }

    }
}
