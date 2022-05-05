using System.Collections.Generic;
using System.Linq;
using FluentValidationUnitTestProject.Models;

namespace FluentValidationLibrary.Base
{
    public class MockOperations
    {

        public static List<Customer> Customers => new()
        {
            new Customer()
            {
                Id = 1, 
                FirstName = "Karen",
                LastName = "Payne",
                Email = "kp@gmail.com",
                SocialSecurity = "205-55-1234",
                Pin = "8888",
                NotesList = new List<string>(), 
                CreditCardNumber = CreditCardNumbersValid.FirstOrDefault()
            },
            new Customer()
            {
                Id = 2,
                FirstName = "Karen",
                LastName = "Payne",
                Email = "kp@gmail.com",
                SocialSecurity = "205-55-1234",
                Pin = "1234",
                NotesList = new List<string>(),
                CreditCardNumber = CreditCardNumbersValid.FirstOrDefault()
            }
        };

        public static List<string> CreditCardNumbersValid =>  new()
        {
            "371144371144376", "341134113411347", "370000000000002",
            "378282246310005", "6011016011016011", "6559906559906557",
            "6011000000000012", "6011111111111117", "5111005111051128",
            "5112345112345114", "5424000000000015", "5105105105105100",
            "4112344112344113", "4007000000027", "4111111111111111",
            "4110144110144115", "4114360123456785", "4061724061724061",
            "5115915115915118", "5116601234567894", "36111111111111",
            "36110361103612", "36438936438936", "30569309025904",
        };

        public static List<string> CreditCardNumbersInValid => new()
        {
            "3566003566003566",
            "3530111333300000",
            "111",
        };
    }
}
