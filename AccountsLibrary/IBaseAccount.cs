using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsLibrary.Models;

namespace AccountsLibrary
{
    /// <summary>
    /// Defines common methods and properties for banking
    /// </summary>
    interface IBaseAccount
    {
        decimal Balance { get; }
        public decimal Deposit(Transaction transaction);
        public decimal Withdraw(Transaction transaction);
    } 

}
