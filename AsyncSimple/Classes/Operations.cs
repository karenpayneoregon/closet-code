using System.Collections.Generic;
using System.Threading.Tasks;
using AsyncSimple.Models;

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
