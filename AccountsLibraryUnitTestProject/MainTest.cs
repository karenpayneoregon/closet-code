using System;
using System.Collections.Generic;
using System.Linq;
using AccountsLibrary;
using AccountsLibrary.Classes;
using AccountsLibrary.Models;
using AccountsLibraryUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace AccountsLibraryUnitTestProject
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Banking)]
        public void AccountExistsTest()
        {
            // arrange
            int accountId = 1;

            // act
            var account = AccountOperations.GetAccount(accountId);

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
            var account = AccountOperations.GetAccount(accountId);

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
            var account = AccountOperations.GetAccount(accountId);
            
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
            var account = AccountOperations.GetAccount(accountId);
            account.AccountDenialEvent += OnAccountDenial;

            account.Withdraw(new Transaction()
            {
                AccountId = 1, 
                Amount = balance +100, 
                TransactionType = TransactionType.Withdraw, 
                TransactionDate = DateTime.Now,
                Description = "Need money fast"
            });

            account.AccountDenialEvent -= OnAccountDenial;

            Check.That(account.Balance).Equals(-100);

        }

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
        [TestTraits(Trait.Other)]
        public void ToEnumFromInt()
        {
            Console.WriteLine(0.ToEnum<TransactionType>());
            Console.WriteLine(1.ToEnum<TransactionType>());
            Console.WriteLine(2.ToEnum<TransactionType>());
        }



    }
}
