using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWithNoForesight_grouping.Data;

namespace CodeWithNoForesight_grouping.Classes
{
    public class EntityCoreOperations
    {
        public static (bool success, Exception exception) CreateBookDatabase()
        {
            try
            {
                using var context = new BookContext();
                Helpers.CleanDatabase(context);
                return (true, null);
            }
            catch (Exception localException)
            {
                return (false, localException);
            }
        }
    }
}
