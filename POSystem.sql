--CREATE DATABASE PurchaseOrderDb;
--GO
--USE PurchaseOrderDb;
--GO
CREATE TABLE Customers
(
	CustomerId INT CONSTRAINT Customers_PK PRIMARY KEY IDENTITY,
	ContactName NVARCHAR(200),
	City NVARCHAR(50)
)
GO
INSERT INTO Customers (ContactName,City) VALUES ('Pravinkumar R. D.','Pune');
INSERT INTO Customers (ContactName,City) VALUES ('Manish Kaushik','Bangalore');
/*
CREATE TABLE Orders
(
	OrderId INT IDENTITY CONSTRAINT Orderd_PK PRIMARY KEY,
	OrderDate Date,
	RequiredDate Date,
	Quantity INT,
	CustomerId INT REFERENCES Customers(CustomerId)
)
*/
GO

CREATE PROCEDURE GetAllCustomers AS
BEGIN
	SELECT * FROM Customers;
END
GO

CREATE PROCEDURE GetCustomerDetails
(
	@p_CustomerId INT
)
 AS
BEGIN
	SELECT * FROM Customers WHERE CustomerId=@p_CustomerId;
END
GO
CREATE PROCEDURE InsertCustomer
(
	@p_ContactName NVARCHAR(200),
	@p_City NVARCHAR(200)
)
 AS
BEGIN
	INSERT INTO Customers (ContactName,City) VALUES (@p_ContactName,@p_City);
END
GO

select City,ContactName from customers for xml auto,elements;