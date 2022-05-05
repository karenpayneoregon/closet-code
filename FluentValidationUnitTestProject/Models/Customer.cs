using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationUnitTestProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal CreditLimit { get; set; }
        public string CreditCardNumber { get; set; }
        public int Discount { get; set; }
        public bool HasDiscount { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Pin { get; set; }
        public string SocialSecurity { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> NotesList { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";

    }
}
