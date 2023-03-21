select p.Name, c.Name from Products p 
left join RelProductsCategories rel on rel.ProductId = p.Id 
left join Categories c on rel.CategoryId = c.Id 



CREATE TABLE MainDb.dbo.Categories (
	Id int NOT NULL,
	Name varchar(50) COLLATE Cyrillic_General_CI_AS NULL,
	CONSTRAINT PK_Categories PRIMARY KEY (Id)
);

CREATE TABLE MainDb.dbo.Products (
	Id int NOT NULL,
	Name varchar(50) COLLATE Cyrillic_General_CI_AS NULL,
	CONSTRAINT PK_Products PRIMARY KEY (Id)
);

CREATE TABLE MainDb.dbo.RelProductsCategories (
	Id int NOT NULL,
	ProductId int NOT NULL,
	CategoryId int NOT NULL,
	CONSTRAINT PK_RelProductsCategories PRIMARY KEY (Id),
	CONSTRAINT CategoryId FOREIGN KEY (CategoryId) REFERENCES MainDb.dbo.Categories(Id),
	CONSTRAINT ProductId FOREIGN KEY (ProductId) REFERENCES MainDb.dbo.Products(Id)
);