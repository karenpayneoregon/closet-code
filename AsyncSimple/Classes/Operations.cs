using System.Collections.Generic;
using System.Threading.Tasks;
using AsyncSimple.Models;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace AsyncSimple.Classes
{
    /// <summary>
    /// Mock-up for a stubborn coder in a forum
    /// </summary>
    public class Operations
    {
        public delegate void OnIterate(Customer customer);
        public static event OnIterate IterateEvent;
        public static async Task<List<Customer>> GetCustomerLists()
        {
            await Task.Delay(0);

            return new List<Customer>();
        }

        public static async Task<bool> Work()
        {
            var customerLists = await GetCustomerLists();

            foreach (var customer in customerLists)
            {
                if (customer.HasDiscount)
                {
                    IterateEvent?.Invoke(customer);
                    // do something here
                    return false;
                }
            }

            return true;
        }
    }
}
