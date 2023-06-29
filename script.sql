CREATE TABLE Product(
Id INT IDENTITY PRIMARY KEY,
[Name] NVARCHAR(300))

GO

CREATE TABLE Category(
Id INT IDENTITY PRIMARY KEY,
[Name] NVARCHAR(300))

GO

CREATE TABLE ProductCategory(
ProductId INT REFERENCES Product,
CategoryId INT REFERENCES Category,
PRIMARY KEY(ProductId, CategoryId))

GO

INSERT Category ([Name]) VALUES
(N'Food'),
(N'Transport')

GO

INSERT Product ([Name]) VALUES 
(N'Milk'),
(N'Water'),
(N'BMW'),
(N'Table')

GO

INSERT ProductCategory ([ProductId], [CategoryId]) VALUES 
(1, 1),
(2, 1),
(3, 2)

GO

SELECT p.Name, c.Name 
FROM Product p 
LEFT JOIN ProductCategory pc
	ON p.Id = pc.ProductId 
LEFT JOIN Category c 
	ON pc.CategoryId = c.Id
