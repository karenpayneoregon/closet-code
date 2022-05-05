using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReturningInformation.Classes;
using ReturningInformation.Models;
using SomeThirdPartyLibrary.Classes;


// ReSharper disable once CheckNamespace - do not change
namespace ReturningInformationUnitTestProject
{
    /// <summary>
    /// Both list are created for all test in <see cref="Initialization"/>, the alternate is to create each list
    /// only when needed as in <see cref="AlternateInitialization"/>.
    /// </summary>
    public partial class MainTest
    {

        private List<Customer> _customersList;
        private List<Person> _personEntitiesList;

        [TestInitialize]
        public void Initialization()
        {
            if (_customersList is null)
            {
                _customersList = FileOperations.GetCustomers();
            }

            if (_personEntitiesList is null)
            {
                _personEntitiesList = FileOperations.GetStudents();
            }


        }

        public void AlternateInitialization()
        {

            if (TestContext.TestName == nameof(DeconstructPeopleTest))
            {
                _personEntitiesList = FileOperations.GetStudents();
            }

            if (TestContext.TestName is (nameof(DeconstructCustomerNameTest)) or (nameof(DeconstructCustomerNameContactIdTest)))
            {
                _customersList = FileOperations.GetCustomers();
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
