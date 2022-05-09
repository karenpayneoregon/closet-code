using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowProperties.Classes
{
    public class SetupOperations
    {
        public static async Task Initialize()
        {
            await CreateOperations.NewDatabase();
            await BogusOperations.PopulateContact1Table(10);
            int[] identifiers = { 4, 7 };
            await BogusOperations.RemoveSomeRecords(identifiers);
        }
  
    }
}
