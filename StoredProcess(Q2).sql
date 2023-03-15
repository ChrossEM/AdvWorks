CREATE PROCEDURE GetProductInfo
AS
BEGIN
    SELECT Name, Price, SUM(Quantity) AS TotalQuantity
    FROM Product
    GROUP BY Name, Price
END

EXEC GetProductInfo






