using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsLibraryUnitTestProject.Base;


// ReSharper disable once CheckNamespace - do not change
namespace AccountsLibraryUnitTestProject
{
    public partial class CheckingAccountTest
    {

        [TestInitialize]
        public void Initialization()
        {
            
            MockOperations.AccountToJsonFile();
            if (MockOperations.AccountFileDoesNotExists)
            {
            }

        }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
