using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AccountsLibrary;
using AccountsLibrary.LanguageExtensions;
using AccountsLibrary.Models;
using AccountsLibraryUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountsLibraryUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class UtilityTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Utility)]
        public void ToEnumFromInt()
        {
            Console.WriteLine(0.ToEnum<TransactionType>());
            Console.WriteLine(1.ToEnum<TransactionType>());
            Console.WriteLine(2.ToEnum<TransactionType>());


        }

    }

}