SELECT OrderID, 
       CustomerIdentifier, 
       OrderDate, 
       ShippedDate, 
       Freight, 
       ShipAddress, 
       ShipCity, 
       ShipPostalCode, 
       ShipCountry, 
       IIF(IsDeleted = 1, 'Yes', 'No') AS IsDeleted
FROM NorthWindAzure3.dbo.Orders
---WHERE dbo.Orders.CustomerIdentifier = 18;
WHERE IsDeleted = 1



