using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReturningInformation.Classes;
using ReturningInformationUnitTestProject.Base;

namespace ReturningInformationUnitTestProject
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.Deconstruct)]
        public void ReadCustomersFromJsonTest()
        {
            Assert.AreEqual(_customersList.Count, 91);
        }
        [TestMethod]
        [TestTraits(Trait.Deconstruct)]
        public void ReadPeopleFromJsonTest()
        {
            Assert.AreEqual(_personEntitiesList.Count, 5);
        }
        #region third party

        [TestMethod]
        [TestTraits(Trait.Deconstruct)]
        public void DeconstructCustomerNameContactIdTest()
        {

            // arrange
            var expectedCompanyName = "Antonio Moreno Taquería";
            var expectedContactId = 3;

            // act
            var (_, companyName, contactIdentifier, _) = _customersList.FirstOrDefault(customer => customer.CustomerIdentifier == 3);
            
            // assert
            Assert.AreEqual(companyName, expectedCompanyName);
            Assert.AreEqual(contactIdentifier, expectedContactId);


        }

        [TestMethod]
        [TestTraits(Trait.Deconstruct)]
        public void DeconstructCustomerNameTest()
        {

            // arrange
            var expectedCompanyName = "Antonio Moreno Taquería";

            // act
            var (_, companyName) = _customersList.FirstOrDefault(customer => customer.CustomerIdentifier == 3);

            // assert
            Assert.AreEqual(companyName, expectedCompanyName);

        }

        #endregion

        [TestMethod]
        [TestTraits(Trait.Deconstruct)]
        public void DeconstructPeopleTest()
        {

            int id = 10;
            var expectFirstName = "Meredith";
            var expectedLastName = "Alonso";

            var ( _, firstName, lastName) = _personEntitiesList.FirstOrDefault(person => person.PersonID == id);
            Assert.AreEqual(firstName, expectFirstName);
            Assert.AreEqual(lastName, expectedLastName);

        }

    }
}
