namespace AccountsLibrary.Models
{
    /// <summary>
    /// Used to group an account data
    /// </summary>
    public class AccountGroupItem
    {
        public int AccountId { get; }
        public CheckingAccount Account { get; }

        public AccountGroupItem(int accountId, CheckingAccount account)
        {
            AccountId = accountId;
            Account = account;
        }
    }
}