using System;
using System.Collections.Generic;
using DataGridViewEntityChecked.Models;

namespace DataGridViewEntityChecked.Classes
{
    public class DataOperations
    {
        public static (bool success, Exception exception) RemoveRange(List<Categories> list)
        {
            try
            {
                // remove items here
                // Set each entity state
                // perform SaveChanges
                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }
    }
}