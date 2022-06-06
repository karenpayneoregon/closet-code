namespace AccountsLib.Classes
{
    public class Account
	{
		private decimal _warningLevel;
		private decimal _balance;

		public event AccountBalanceWarningEventHandler AccountBalanceWarningEvent;
		public event AccountDenyingEventHandler AccountDenialEvent;

		public string Number { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Account()
		{
			_warningLevel = 10M;
		}

		/// <summary>
		/// Warning level is when to send an alert via our delegate
		/// </summary>
		/// <param name="warningLevel"></param>
		/// <remarks></remarks>
		public Account(decimal warningLevel)
		{
			_warningLevel = warningLevel;
			_mnsufficientFunds = _balance <= 0M;
		}
		/// <summary>
		/// Current balance of account
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		public decimal Balance => _balance;

        /// <summary>
		/// Deposit money into account
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		public decimal Deposit(decimal amount)
		{
			_balance += amount;

			if ( _balance < _warningLevel && AccountBalanceWarningEvent is not null)
			{
                AccountBalanceWarningEvent?.Invoke(
                    this, 
                    new(Number, _warningLevel, _balance));
            }

			if ( _balance - amount < 0M)
			{
				_mnsufficientFunds = true;
                AccountDenialEvent?.Invoke(
                    this, 
                    new(DenialReasons.InsufficientFunds));
            }
			else
			{
				_mnsufficientFunds = false;
			}

			return _balance;

		}
		/// <summary>
		/// Withdraw from account
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		public decimal Debit(decimal amount)
		{
			if (_balance - amount < 0M)
			{
				// Deny withdraw
				_mnsufficientFunds = true;
                AccountDenialEvent?.Invoke(
                    this, 
                    new(DenialReasons.InsufficientFunds));

                return _balance;
			}

			_balance -= amount;

			AccountBalanceWarningEvent?.Invoke(
                this, 
                new(Number, _warningLevel, _balance));

			return _balance;

		}
		private bool _mnsufficientFunds;
		public bool InsufficientFunds => _mnsufficientFunds;

        public override string ToString() => Balance.ToString("c2");
    }
}