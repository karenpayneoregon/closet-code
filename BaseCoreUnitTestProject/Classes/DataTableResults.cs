using System;
using System.Data;

namespace BaseCoreUnitTestProject.Classes
{
    public class DataTableResults
    {
        /// <summary>
        /// Holds data read from a database.
        /// </summary>
        public DataTable DataTable { get; set; }
        /// <summary>
        /// Set when there is a connection to the server failure
        /// </summary>
        public bool ConnectionFailed { get; set; }
        /// <summary>
        /// General exception message
        /// </summary>
        public string ExceptionMessage { get; set; }
        /// <summary>
        /// General exception if not connection failure
        /// </summary>
        public Exception GeneralException { get; set; }
        /// <summary>
        /// Is there an exception thrown
        /// </summary>
        public bool HasException => ConnectionFailed || GeneralException != null;
    }
}