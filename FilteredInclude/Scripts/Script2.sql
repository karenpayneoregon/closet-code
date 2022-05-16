SELECT O.OrderID, 
       O.CustomerIdentifier, 
       O.OrderDate, 
       O.ShippedDate, 
       O.Freight, 
       O.ShipAddress, 
       O.ShipCity, 
       O.ShipPostalCode, 
       O.ShipCountry, 
       O.IsDeleted, 
       OD.ProductID, 
       Products.ProductName
FROM Orders AS O
     INNER JOIN OrderDetails AS OD ON O.OrderID = OD.OrderID
     INNER JOIN Products ON OD.ProductID = Products.ProductID
WHERE O.OrderID = 10248;
