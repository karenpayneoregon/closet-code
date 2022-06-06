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
		public Account(decimal warningLevel)
		{
			_warningLevel = warningLevel;
			_insufficientFunds = _balance <= 0M;
		}
		/// <summary>
		/// Current balance of account
		/// </summary>
		public decimal Balance => _balance;

        /// <summary>
		/// Deposit money into account
		/// </summary>
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
				_insufficientFunds = true;
                AccountDenialEvent?.Invoke(
                    this, 
                    new(DenialReasons.InsufficientFunds));
            }
			else
			{
				_insufficientFunds = false;
			}

			return _balance;

		}
		/// <summary>
		/// Withdraw from account
		/// </summary>
		public decimal Debit(decimal amount)
		{
			if (_balance - amount < 0M)
			{
				// Deny withdraw
				_insufficientFunds = true;
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
		private bool _insufficientFunds;
		public bool InsufficientFunds => _insufficientFunds;

        public override string ToString() => Balance.ToString("c2");
    }
}