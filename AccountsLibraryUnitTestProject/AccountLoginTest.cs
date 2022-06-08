using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AccountsLibrary.Classes;
using AccountsLibrary.Models;
using AccountsLibraryUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace AccountsLibraryUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class AccountLoginTest : TestBase
    {

        [TestMethod]
        [TestTraits(Trait.Banking)]
        public void ValidateAccountCountLogin()
        {
            List<CheckingAccount> accounts = AccountOperations.ReadAccountsFromFile();
            Check.That(accounts.Count).Equals(2);
        }

    }

}