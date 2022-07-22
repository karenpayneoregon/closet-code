using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseCoreUnitTestProject.Base;
using BaseCoreUnitTestProject.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseCoreUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class SqlTests : TestBase
    {

        /// <summary>
        /// Half-baked test in that the class method to test
        /// resides in the test project and the connection string
        /// is hard-wired which for a real app would be in appsettings.json
        ///
        /// The test, validate a timeout on a data connection
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestTraits(Trait.CancellationToken)]
        public async Task TimeOutTest()
        {
            // arrange
            DataOperations.RunWithIssues = true;

            // act
            var dataResults = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            // assert
            Assert.IsTrue(
                dataResults.HasException && 
                dataResults.ExceptionMessage == "Connection Failed");
        }

    }

}