﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// ReSharper disable once CheckNamespace - do not change
namespace FilteredIncludeUnitTestProject
{
    public partial class MainTest
    {

        [TestInitialize]
        public void Initialization()
        {
            if (TestContext.TestName == nameof(SimpleGetAnyOrdersIsDeletedTest))
            {
                // TODO
            }
        }

        /// <summary>
        /// Perform cleanup after test runs using assertion on current test name.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == nameof(SimpleGetAnyOrdersIsDeletedTest))
            {
                // TODO
            }
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
