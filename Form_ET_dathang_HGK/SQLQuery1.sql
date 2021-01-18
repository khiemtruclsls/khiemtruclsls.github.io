create table Category (
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(100) NOT NULL
);

create table Product (
	Id int primary key identity,
	[Name] nvarchar(150) NOT NULL,
	Price int NOT NULL DEFAULT(0),
	CateId int NOT NULL FOREIGN KEY REFERENCES Category(Id)
)
;

create table [Order] (
	Id int primary key identity,
	ordDate date NOT NULL,
	ClientName nvarchar(150)
);
create table OrderProduct (
	ProductId int NOT NULL FOREIGN KEY REFERENCES Product(Id),
	OrderId int NOT NULL FOREIGN KEY REFERENCES [Order](Id),
	Quantity int NOT NULL DEFAULT(1),
	Price int NOT NULL DEFAULT(0),
	PRIMARY KEY (ProductId,OrderId)
)
;
select * from OrderProduct