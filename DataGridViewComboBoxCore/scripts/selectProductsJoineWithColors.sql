 
SELECT P.id,
       P.Item,
       P.ColorId,
       C.ColorText,
       P.CustomerId,
       P.Qty,
       P.InCart,
       P.VendorId
FROM dbo.Product AS P
    INNER JOIN dbo.Colors AS C
        ON P.ColorId = C.ColorId;
