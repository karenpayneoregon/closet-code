using System;
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
        [TestTraits(Trait.PlaceHolder)]
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

    }
}
