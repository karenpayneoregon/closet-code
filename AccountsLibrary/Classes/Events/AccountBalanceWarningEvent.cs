namespace AccountsLibrary.Classes.Events
{
    public delegate void AccountBalanceWarningEvent(
        object sender, 
        AccountBalanceWarningEventArgs e);
}