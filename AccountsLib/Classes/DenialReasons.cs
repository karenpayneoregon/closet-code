namespace AccountsLib.Classes
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// SuspiciousActivity is not used here yet
    /// in real life banks monitor activity and
    /// may flag an account inactive if say five 
    /// purchases where made in a very short time
    /// period.
    /// </remarks>
    public enum DenialReasons
	{
		InsufficientFunds,
		SuspiciousActivity
	}


}