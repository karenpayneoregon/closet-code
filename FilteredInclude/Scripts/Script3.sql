USE [NorthWindAzure3]
SELECT O.OrderID, 
       O.CustomerIdentifier, 
       P.ProductName
FROM Orders AS O
     INNER JOIN OrderDetails AS OD ON O.OrderID = OD.OrderID
     INNER JOIN Products AS P ON OD.ProductID = P.ProductID
WHERE O.IsDeleted = 1
ORDER BY O.OrderID;