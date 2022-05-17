# About

Examples for EF Core `Filtered includes`

Microsoft [docs](https://docs.microsoft.com/en-us/ef/core/querying/related-data/eager#filtered-include)

Example in code (Global Query Filters can do the same as done here).

```csharp
List<IEnumerable<Orders>> filteredOnIsDeletedCustomers = context.Customers
    .Where(customer => customer.Orders.Any(order => order.IsDeleted.Value))
    .Include(customer => customer.Orders.Where(order => order.IsDeleted.Value == true))
    .ThenInclude(order => order.OrderDetails)
    .ThenInclude(orderDetails => orderDetails.Product)
    .Select(customer => customer.Orders.Where(order => order.IsDeleted.Value)).ToList();
```


**Caution**

In case of tracking queries, results of Filtered Include may be unexpected due to navigation fixup. All relevant entities that have been queried for previously and have been stored in the Change Tracker will be present in the results of Filtered Include query, even if they don't meet the requirements of the filter. 

Consider using [NoTracking](https://docs.microsoft.com/en-us/ef/core/querying/tracking) queries or re-create the DbContext when using Filtered Include in those situations.