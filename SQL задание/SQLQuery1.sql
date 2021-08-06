create table Products(
[ID] uniqueidentifier  NOT NULL PRIMARY KEY,
[Name] varchar(24)
);

create table Categories(
[ID] uniqueidentifier  NOT NULL PRIMARY KEY,
[Name] varchar(24)
);

create table ProductsVsCategories(
ProductID uniqueidentifier FOREIGN KEY REFERENCES Products(ID),
CategoriesID uniqueidentifier FOREIGN KEY REFERENCES Categories(ID)
);


Insert INTO Products values (NEWID(),'Товар8');
select*from Products

Insert INTO Categories values (NEWID(),'Категория5');
select*from Categories

Insert INTO ProductsVsCategories values ('2FF4EF74-C41A-4DA2-AD99-A36651A7A159','D118D3BD-D8B0-4FB0-A3A3-A21A84CA15D2');
select*from ProductsVsCategories

select 
Products.Name,
Categories.Name
from Products
--задание
left join ProductsVsCategories on Products.ID = ProductsVsCategories.ProductID
left join Categories on Categories.ID = ProductsVsCategories.CategoriesID

--для проверки
--full outer join ProductsVsCategories on Products.ID = ProductsVsCategories.ProductID  
--full outer join Categories on Categories.ID = ProductsVsCategories.CategoriesID

