using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.CommonRules;
using RulesUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using RulesUnitTestProject.Classes;

namespace RulesUnitTestProject
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class CustomerYearRangeTest : TestBase
    {

        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void ValidYearTest()
        {
            // arrange
            var customer = Customer;

            // act
            var (success, _) = ValidationOperations.IsValidEntity(customer);

            // assert

            Check.That(success).IsTrue();
        }

        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void InValidMinimumYearTest()
        {
            // arrange
            var customer = Customer;

            customer.BirthDate = new DateTime(2023, 1, 1);

            // act
            var (success, _) = ValidationOperations.IsValidEntity(customer);

            // assert

            Check.That(success).IsFalse();
        }

        /// <summary>
        /// Shows how to perform IsValid on <see cref="YearRangeAttribute"/> without an entire
        /// instance of a model.
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void RawYearRangeTest()
        {
            var customer = Customer;

            var yearRangeTest = new YearRangeAttribute(2022)
            {
                MinimumYear = 1932
            };

            // BirthDate is in proper range
            Check.That(yearRangeTest.IsValid(customer.BirthDate)).IsTrue();

            // BirthDate year is out of max range
            customer.BirthDate = new DateTime(2023, 1, 1);
            Check.That(yearRangeTest.IsValid(customer.BirthDate)).IsFalse();

            // BirthDate year is out of min range
            customer.BirthDate = new DateTime(1931, 1, 1);
            Check.That(yearRangeTest.IsValid(customer.BirthDate)).IsFalse();

        }


        [TestMethod]
        [TestTraits(Trait.CustomAnnotationAttribute)]
        public void InValidMaxYearTest()
        {
            // arrange
            var customer = Customer;

            customer.BirthDate = new DateTime(2030, 1, 1);

            // act
            var (success, _) = ValidationOperations.IsValidEntity(customer);

            // assert

            Check.That(success).IsFalse();
        }
    }

}