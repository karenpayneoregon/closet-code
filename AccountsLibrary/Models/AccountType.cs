using System.ComponentModel;

namespace AccountsLibrary.Models
{
    public enum AccountType
    {
        [Description("Checking account")]
        Checking,
        [Description("Savings account")]
        Savings,
        [Description("Individual Retirement Account")]
        IRA
    }
}