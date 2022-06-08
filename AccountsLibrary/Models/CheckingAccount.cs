using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsLibrary.Interfaces;

/*
 * Samples for using an interface
 */
namespace AccountsLibrary.Models
{

    class CheckingAccount : IBaseAccount
    {
        public decimal Balance { get; }
        public decimal Deposit(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public decimal Withdraw(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
