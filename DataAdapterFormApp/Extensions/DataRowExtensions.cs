using System;
using System.Data;
using System.Reflection;
using DataAdapterFormApp.Classes;

namespace DataAdapterFormApp.Extensions
{
    /// <summary>
    /// Extension method in this class should be used with care.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get current DataRow Id
        /// </summary>
        /// <param name="row">Valid DataRow</param>
        /// <returns>Row id</returns>
        public static int RowId(this DataRow row)
        {
            FieldInfo fieldInfo = row.GetType().GetField("_rowID", BindingFlags.NonPublic | BindingFlags.Instance);
            return Convert.ToInt32(fieldInfo.GetValue(row));
        }

        /// <summary>
        /// For obtaining a new primary key after performing a save from <seealso cref="EmployeeOperations.SaveChanges"/>
        /// </summary>
        /// <param name="row">Valid DataRow state will be unchanged to use</param>
        /// <returns>new primary key</returns>
        /// <remarks>
        /// TODO
        /// </remarks>
        public static int ObjectIdentifier(this DataRow row)
        {
            FieldInfo fieldInfo = row.GetType().GetField("ObjectID", BindingFlags.NonPublic | BindingFlags.Instance);
            return Convert.ToInt32(fieldInfo.GetValue(row));
        }
    }
}