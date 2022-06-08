
using AccountsLibrary.Interfaces;

namespace AccountsLibrary.Models
{
    /// <summary>
    /// Used to group an account data which implements <see cref="IBaseAccount"/>
    /// </summary>
    public class GroupContainer
    {
        public int AccountId { get; }
        public IBaseAccount Account { get; }

        public GroupContainer(int accountId, CheckingAccount account)
        {
            AccountId = accountId;
            Account = account;
        }
    }
}