create table Towns
(
	Id int not null,
	[Name] varchar(50) not null,
	constraint PK_Towns Primary key(Id)
);

create table Minions
(
	Id int not null,
	[Name] varchar(50) not null,
	Age int,
	TownId int,
	constraint PK_Minions primary key(Id),
	constraint FK_Towns foreign key(TownId) references Towns(Id)
);

-- 04
insert into Towns
values(1, 'Sofia'),
	  (2, 'Plovdiv'),
	  (3, 'Varna');

insert into Minions
values(1, 'Kevin', 22, 1),
	  (2, 'Bob', 15, 3),
	  (3, 'Steward', null, 2);

-- 05
truncate table Minions;

-- 06
drop table Minions;
drop table Towns;

-- 07
create table People
(
	Id int identity(1,1) not null,
	[Name] nvarchar(200) not null,
	Picture image,
	Height decimal,
	[Weight] decimal,
	Gender char(1) not null,
	Birthdate datetime2 not null,
	Biography text,
	constraint PK_People Primary key(Id)
);

insert into People([Name], Gender,Birthdate) 
values('Pesho', 'm', '1999-01-01'),
      ('Pesho', 'm', '1999-01-01'),
	  ('Pesho', 'm', '1999-01-01'),
      ('Pesho', 'm', '1999-01-01'),
	  ('Pesho', 'm', '1999-01-01')

-- 08
create table Users
(
	Id int Identity not null,
	Username varchar(30)not null,
	[Password] varchar(26) not null,
	ProfilePicture image,
	LastLoginTime datetime2,
	IsDeleted tinyint not null,
	constraint PK_Users Primary key(Id)
);

insert into Users(Username, [Password], IsDeleted) 
values('Pesho', '123', 0),
      ('Pesho', '123', 0),
	  ('Pesho', '123', 0),
	  ('Pesho', '123', 0),
	  ('Pesho', '123', 0)

-- 09
alter table Users
drop constraint PK_Users;

alter table Users
add constraint PK_Users Primary key(Id, [Username])

-- 13
create database Movies;
use Movies;


create table Directors
(
	Id int Identity not null,
	DirectorName varchar(50) not null,
	Notes varchar,
	constraint PK_Directors primary key(Id)
);

create table Genres
(
	Id int Identity not null,
	GenreName varchar(50) not null,
	Notes varchar,
	constraint PK_Genres primary key(Id)
);

create table Categories
(
	Id int Identity not null,
	CategoryName varchar(50) not null,
	Notes varchar(50)
	constraint PK_Categories primary key(Id)
);

create table Movies
(
	Id int Identity not null,
	Title varchar(50) not null,
	DirectorId int not null,
	CopyrightYear int,
	Lenght time,
	GenreId int not null,
	CategoryId int not null,
	Rating decimal,
	Notes varchar,
	constraint PK_Movies primary key(Id),
	constraint FK_Directors foreign key(DirectorId)
			   references Directors(Id),
	constraint FK_Genre foreign key(GenreId)
			   references Genres(Id),
	constraint FK_Category foreign key(CategoryId)
			   references Categories(Id)
);
INSERT INTO [Directors] VALUES
	('Stanley Kubrick', NULL),
	('Alfred Hitchcock', NULL),
	('Quentin Tarantino', NULL),
	('Steven Spielberg', NULL),
	('Martin Scorsese', NULL)

INSERT INTO [Genres] VALUES
	('Action', NULL),
	('Comedy', NULL),
	('Drama', NULL),
	('Fantasy', NULL),
	('Horror', NULL)

INSERT INTO [Categories] VALUES
	('Short', NULL),
	('Long', NULL),
	('Biography', NULL),
	('Documentary', NULL),
	('TV', NULL)

INSERT INTO [Movies] VALUES
	('The Shawshank Redemption', 1, 1994, '02:22:00', 2, 3, 9.4, NULL),
	('The Godfather', 2, 1972, '02:55:00', 3, 4, 9.2, NULL),
	('Schindler`s List', 3, 1993, '03:15:00', 4, 5, 9.0, NULL),
	('Pulp Fiction', 4, 1994, '02:34:00', 5, 1, 8.9, NULL),
	('Fight Club', 5, 1999, '02:19:00', 1, 2, 8.8, NULL)
-- 14
create database CarRental
use CarRental
CREATE TABLE [Categories]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(50) NOT NULL,
	[DailyRate] DECIMAL(6, 2) NOT NULL,
	[WeeklyRate] DECIMAL(6, 2) NOT NULL,
	[MonthlyRate] DECIMAL(6, 2) NOT NULL,
	[WeekendRate] DECIMAL(6, 2) NOT NULL
)

CREATE TABLE [Cars]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[PlateNumber] VARCHAR(30) NOT NULL,
	[Manufacturer] VARCHAR(50) NOT NULL,
	[Model] VARCHAR(50) NOT NULL,
	[CarYear] INT NOT NULL,
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories](Id) NOT NULL,
	[Doors] INT NOT NULL,
	[Picture] IMAGE,
	[Condition] NVARCHAR(1000) NOT NULL,
	[Available] BIT NOT NULL
)

CREATE TABLE [Employees]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(30) NOT NULL,
	[LastName] VARCHAR(30) NOT NULL,
	[Title] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [Customers]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[DriverLicenceNumber] INT NOT NULL,
	[FullName] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(200) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[ZIPCode] INT NOT NULL,
	[Notes] NVARCHAR(1000)
)

CREATE TABLE [RentalOrders]
(
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id) NOT NULL,
	[CustomerId] INT FOREIGN KEY REFERENCES [Customers](Id) NOT NULL,
	[CarId] INT FOREIGN KEY REFERENCES [Cars](Id) NOT NULL,
	[TankLevel] INT NOT NULL,
	[KilometrageStart] INT NOT NULL,
	[KilometrageEnd] INT NOT NULL,
	[TotalKilometrage] INT NOT NULL,
	[StartDate] DATE NOT NULL,
	[EndDate] DATE NOT NULL,
	[TotalDays] INT NOT NULL,
	[RateApplied] DECIMAL(6, 2) NOT NULL,
	[TaxRate] DECIMAL(4, 2) NOT NULL,
	[OrderStatus] VARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(1000)
)

INSERT INTO [Categories] VALUES
	('First category name', 10.00, 50.00, 150.00, 20.00),
	('Second category name', 50.00, 250.00, 750.00, 100.00),
	('Third category name', 100.00, 500.00, 1500.00, 200.00)

INSERT INTO [Cars] VALUES
	('PLN 0001', 'Ford', 'Model A', 1994, 1, 4, NULL, 'Good', 1),
	('PLN 0002', 'Tesla', 'Model B', 2021, 2, 4, NULL, 'Great', 1),
	('PLN 0003', 'Capsule Corp', 'Model C', 2054, 3, 10, NULL, 'Best', 0)

INSERT INTO [Employees] VALUES
	('Tyler', 'Durden', 'Edward Norton`s Alter Ego', NULL),
	('Plain', 'Jane', 'some gal', NULL),
	('Average', 'Joe', 'some dude', NULL)

INSERT INTO [Customers] VALUES
	('123456', 'Jimmy Carr', 'Britain', 'London', 1000, NULL),
	('654321', 'Bill Burr', 'USA', 'Washington', 2000, NULL),
	('999999', 'Louis CK', 'Mexico', 'Mexico City', 3000, NULL)

INSERT INTO [RentalOrders] VALUES
	(1, 1, 1, 70, 90000, 100000, 10000, '1994-10-01', '1994-10-21', 20, 100.00, 14.00, 'Pending', NULL),
	(2, 2, 2, 85, 250000, 2750000, 25000, '2011-11-12', '2011-11-24', 12, 150.00, 17.50, 'Canceled', NULL),
	(3, 3, 3, 90, 0, 120000, 120000, '2025-04-05', '2025-05-02', 27, 220.00, 21.25, 'Delivered', NULL)




-- 15

create database Hotel;
go;
use Hotel;

create table Employees
(
	Id int identity,
	FirstName varchar(50) not null,
    LastName varchar(50) not null,
	Titles varchar(50),
	Notes varchar(100),

	constraint PK_Employees primary key(Id)
);

create table Customers
(
	AccountNumber int Identity,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	PhoneNumber int,
	EmergencyName varchar(50),
	EmergencyNumber varchar(50),
	Notes varchar(100),

	constraint PK_Customers primary key(AccountNumber)
);

create table RoomStatus
(
	RoomStatus varchar(50) not null,
	Notes varchar(100),

	constraint PK_RoomStatus primary key(RoomStatus)
);

create table RoomTypes
(
	RoomType varchar(50) not null,
	Notes varchar(100),

	constraint PK_RoomTypes primary key(RoomType)
);

create table BedTypes
(
	BedType varchar(50) not null,
	Notes varchar(100),

	constraint PK_BedTypes primary key(BedType)
);

create table Rooms
(
	RoomNumber int not null,
	RoomType varchar(50) not null,
	BedType varchar(50) not null,
	Rate decimal(5,2),
	Notes varchar(100),

	constraint PK_Rooms primary key(RoomNumber),
	constraint FK_RoomTypes_Rooms foreign key(RoomType)
			references RoomTypes(RoomType),
	constraint FK_BedTypes_Rooms foreign key(BedType)
			references BedTypes(BedType)
);

create table Payments
(
	Id int Identity,
	EmployeeId int not null,
	PaymentDate datetime2 not null,
	AccountNumber int not null,
	FirstDateOccupied datetime2 not null,
	LastDateOccupied datetime2 not null,
	TotalDays int not null,
	AmountCharged decimal (5,2) not null,
	TaxRate decimal(5,2) not null,
	TaxAmount decimal(5,2) not null,
	PaymentTotal decimal(5,2),
	Notes varchar(50)

	constraint PK_Payments primary key(Id),
	constraint FK_Employees_Payments foreign key(EmployeeId)
			references Employees(Id)
);

create table Occupancies
(
	Id int Identity,
	EmployeeId int not null,
	DateOccupied datetime2,
	AccountNumber int not null,
	RoomNumber int not null,
	RateApplied decimal(5,2) not null,
	PhoneCharge decimal(5,2) not null,
	Notes varchar(100),

	constraint PK_Occupancies primary key(Id),
	constraint FK_Employees_Occupancies foreign key(EmployeeId)
			references Employees(Id),
	constraint FK_Rooms_Occupancies foreign key(RoomNumber)
			references Rooms(RoomNumber)
);


INSERT INTO [Employees] VALUES
	('Jim', 'McJim', 'Supervisor', NULL),
	('Jane', 'McJane', 'Cook', NULL),
	('John', 'McJohn', 'Waiter', NULL)
		
INSERT INTO [Customers] VALUES
	('Mickey', 'Mouse', 12345678, 'Minnie', 11111111, NULL),
	('Donald', 'Duck', 87654321, 'Daisy', 22222222, NULL),
	('Scrooge', 'McDuck', 9999999, 'Richie', 33333333, NULL)
		
INSERT INTO [RoomStatus] VALUES
	('Free', NULL),
	('Occupied', NULL),
	('No idea', NULL)
		
INSERT INTO [RoomTypes] VALUES
	('Room', NULL),
	('Studio', NULL),
	('Apartment', NULL)
		
INSERT INTO [BedTypes] VALUES
	('Big', NULL),
	('Small', NULL),
	('Child', NULL)
		
INSERT INTO [Rooms] VALUES
	('Room', 'Big', 15.00, 'Free', NULL),
	('Studio', 'Small', 12.50, 'Occupied', NULL),
	('Apartment', 'Child', 10.25, 'No idea', NULL)
		
INSERT INTO [Payments] VALUES
	(1, '2023-02-01', 1, '2023-01-11', '2023-01-14', 3, 250.00, 20.00, 50.00, 300.00, NULL),
	(2, '2023-02-02', 2, '2023-01-12', '2023-01-15', 3, 199.90, 20.00, 39.98, 239.88, NULL),
	(3, '2023-02-03', 3, '2023-01-13', '2023-01-16', 3, 330.50, 20.00, 66.10, 396.60, NULL)
	   	
INSERT INTO [Occupancies] VALUES
	(1, '2023-01-01', 1, 1, 20.00, 15.00, NULL),
	(2, '2023-01-02', 2, 2, 20.00, 12.50, NULL),
	(3, '2023-01-03', 3, 3, 20.00, 18.90, NULL)







































