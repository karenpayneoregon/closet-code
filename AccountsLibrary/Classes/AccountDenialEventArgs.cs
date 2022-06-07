using System;
using AccountsLibrary.Models;

namespace AccountsLibrary.Classes
{
    public class AccountDenialEventArgs : EventArgs
    {
        public AccountDenialEventArgs(DenialReasons Reason)
        {
            this.Reason = Reason;
        }

        public DenialReasons Reason { get; }
    }


}