using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesUnitTestProject.Models;
// ReSharper disable once CheckNamespace
namespace RulesUnitTestProject
{
    public partial class CustomerYearRangeTest
    {
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

        public Customer Customer => new ()
        {
            FirstName = "Karen",
            LastName = "Payne",
            BirthDate = new DateTime(1956,1,1)
        };

    }

}