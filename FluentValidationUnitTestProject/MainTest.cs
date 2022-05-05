using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidationLibrary.Base;
using FluentValidationLibrary.LanguageExensions;
using FluentValidationUnitTestProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace FluentValidationLibrary
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task ValidCustomerTest()
        {
            // arrange
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault();

            // act
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);

            // assert
            Check.That(result.IsValid).IsTrue();

        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task InValidToManyNotesAndInvalidCreditCardNumberCustomerTest()
        {
            // arrange
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault();
            thisCustomer.CreditCardNumber = "111";

            int count = 5;


            string[] expected =
            {
                $"Notes List must contain fewer than {count} items.",
                "'Credit Card Number' is not a valid credit card number."
            };

            thisCustomer.NotesList.AddRange(new []{"2","3","4","5", "6"});
            
            // act
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);
            var errors = result.Errors.Select(x => x.ErrorMessage).ToArray();
            Check.That(errors).ContainsExactly(expected);
            // assert
            //Check.That(result.Errors.FirstOrDefault()!.ErrorMessage).Equals(expected);
        }

        [TestMethod]
        [TestTraits(Trait.FluentValidation)]
        public async Task InvalidPinCustomerTest()
        {
            Customer thisCustomer = MockOperations.Customers.FirstOrDefault(cust => cust.Id == 2);
            
            ValidationResult result = await CustomerValidator.ValidateAsync(thisCustomer);
            
            result.ShowErrorMessage();
            Check.That(result.IsValid).IsFalse();
        }

    }
}
