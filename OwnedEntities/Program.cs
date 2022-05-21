using System;
using System.Linq;
using OwnedEntities.Data;
using OwnedEntities.Models;

namespace OwnedEntities
{
    partial class Program
    {
        static void Main(string[] args)
        {
            using (var context = new OwnedEntityContext())
            {
                Console.WriteLine("Creating");
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Add(
                    new DetailedOrder
                    {
                        Status = OrderStatus.Pending,
                        OrderDetails = new OrderDetails
                        {
                            ShippingAddress = new StreetAddress { City = "London", Street = "221 B Baker St" },
                            BillingAddress = new StreetAddress { City = "New York", Street = "11 Wall Street" }
                        }
                    });

                Console.WriteLine("Saving");
                context.SaveChanges();
            }

            Console.WriteLine("Reading...");
            using (var context = new OwnedEntityContext())
            {
                var order = context.DetailedOrders.First(o => o.Status == OrderStatus.Pending);
                Console.WriteLine($"First pending order will ship to: {order.OrderDetails.ShippingAddress.City}");
            }

            Console.WriteLine("Finished");
            Console.ReadLine();

        }
    }
}
