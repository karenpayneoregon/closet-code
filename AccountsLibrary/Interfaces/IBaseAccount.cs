using AccountsLibrary.Models;

namespace AccountsLibrary.Interfaces
{
    /// <summary>
    /// Defines common methods and properties for banking
    /// </summary>
    public interface IBaseAccount
    {
        decimal Balance { get; }
        public decimal Deposit(Transaction transaction);
        public decimal Withdraw(Transaction transaction);
    } 

}
