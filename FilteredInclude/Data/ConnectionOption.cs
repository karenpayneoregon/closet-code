namespace FilteredInclude.Data
{
    /// <summary>
    /// Specify which server to connect to, SQLEXPRESS or localdb
    /// </summary>
    public enum ConnectionOption
    {
        /// <summary>
        /// Use SQLEXPRESS
        /// </summary>
        SqlExpress,
        /// <summary>
        /// User localdb
        /// </summary>
        mssqllocaldb
    }
}