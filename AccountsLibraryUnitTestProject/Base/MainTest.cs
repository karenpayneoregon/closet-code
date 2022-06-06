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
    public partial class MainTest
    {

        [TestInitialize]
        public void Initialization()
        {
            
            if (MockOperations.AccountFileDoesNotExists)
            {
                MockOperations.AccountToJsonFile();
            }

        }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
