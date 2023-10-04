USE VertivPoDb;
GO
/*
insert into Customers(ContactName,City,BirthDate) values ('Alisha C.','Mumbai',GETDATE())
insert into Customers(ContactName,City,BirthDate) values ('Manish Kaushik','Bangalore',GETDATE())
insert into Customers(ContactName,City,BirthDate) values ('Anis Khan','Mumbai',GETDATE())
insert into Customers(ContactName,City,BirthDate) values ('Rammy John','London',GETDATE())
insert into Customers(ContactName,City,BirthDate) values ('Maria Andrus','London',GETDATE())

insert into Categories(CategoryName,Description) values('Electronics','All Electronic Products!');
insert into Categories(CategoryName,Description) values('Digital','All Digital Products!');

*/
insert into Products(ProductName,Description,UnitPrice,AvailableQuantity,CategoryId) 
values ('Oven','Sony Oven',32000,100,1);

insert into Products(ProductName,Description,UnitPrice,AvailableQuantity,CategoryId) 
values ('Washing Machine','Front Load Bosch Washing Machine',42000,100,1);


select * from Customers;
select * from Categories;
select * from Products;