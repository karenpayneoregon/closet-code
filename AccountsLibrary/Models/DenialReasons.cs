using System.ComponentModel;

namespace AccountsLibrary.Models
{
    public enum DenialReasons
    {
        [Description("Insufficient funds")]
        InsufficientFunds,
        [Description("Detected Suspicious activity")]
        SuspiciousActivity
    }
}