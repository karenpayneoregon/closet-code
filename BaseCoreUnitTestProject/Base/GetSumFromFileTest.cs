using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace BaseCoreUnitTestProject
{
    public partial class GetSumFromFileTest
    {

        private static readonly string _cleanFileName = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFiles", "ExampleClean.txt");

        private static readonly string _malformedFileName = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFiles", "ExampleMalFormed.txt");

        [TestInitialize]
        public void Initialization()
        {

        }

        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }

    }

}