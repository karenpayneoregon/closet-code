namespace AccountsLibrary.Models
{
    /// <summary>
    /// Indicates transaction for <see cref="CheckingAccount"/>, <see cref="SavingsAccount"/> or <see cref="IndividualRetirementAccount"/>
    /// </summary>
    public enum TransactionType
    {
        Deposit,
        Withdraw
    }
}