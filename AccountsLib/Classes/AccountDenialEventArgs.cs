using System;

namespace AccountsLib.Classes
{
    public class AccountDenialEventArgs : EventArgs
	{
		private DenialReasons mReason;
		public AccountDenialEventArgs(DenialReasons Reason)
		{
			mReason = Reason;
		}

		public DenialReasons Reason => mReason;

    }


}