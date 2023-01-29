use Minions

-- 01
drop table Persons
drop table Passports

create table Passports
(
	PassportID int primary key,
	PassportNumber char(8) not null,
);

create table Persons
(
	PersonID int identity primary key,
	FirstName varchar(50) not null,
	Salary decimal(7,2) not null,
	PassportID int not null,
	constraint FK_Passports_Persons foreign key(PassportID)
	references Passports(PassportID)
);

insert into Passports
values (101,'N34FG21B'),
		(102, 'K65LO4R7'),
		(103, 'ZE657QP2');

insert into Persons
values ('Roberto',  43300.00, 102),
		('Tom', 56100.00, 103),
		('Yana', 60200.00, 101);

-- 02

create table Manufacturers
(
	ManufacturerID int primary key identity,
	[Name] varchar(50) not null,
	EstablishedOn datetime2 not null
);

create table Models
(
	ModelID int primary key,
	[Name] varchar(50) not null,
	ManufacturerID int,
	constraint FK_Manufacturers_Models foreign key(ManufacturerID)
				references Manufacturers(ManufacturerID)
);

insert into Manufacturers values
			('BMW', '07/03/1916'),
			('Tesla', '01/01/2003'),
			('Lada', '01/05/1966');

insert into Models values
			(101,'X1', 1),
			(102,'i6', 1),
			(103,'Model S', 2),
			(104,'Model X', 2),
			(105, 'Model 3', 2),
			(106, 'Nova', 3)


-- 03

create table Students
(
	StudentID int identity primary key,
	[Name] varchar(50) not null
);

create table Exams
(
	ExamID int identity(101, 1) primary key,
	[Name] varchar(50) not null
);

create table StudentsExams
(
	StudentID int not null foreign key references Students(StudentID),
	ExamID int not null foreign key references Exams(ExamID),
	constraint PK_StudentsExams primary key(StudentID, ExamID)
);


insert into Students values
			('Mila'),
			('Toni'),
			('Ron');

insert into Exams values
			('SpringMVC'),
			('Neo4j'),
			('Oracle 11g');

insert into StudentsExams values
			(1,101),
			(1,102),
			(2,101),
			(3,103),
			(2, 102),
			(2,103)

-- 04
create table Teachers
(
	TeacherID int identity(101, 1) primary key,
	[Name] varchar(50) not null,
	ManagerID int foreign key references Teachers(TeacherID)
);

insert into Teachers values
			('John',null),
			('Maya', 106),
			('Silvia', 106),
			('Ted', 105),
			('Mark', 101),
			('Greta', 101)

-- 05
create table Cities
(
	CityID int primary key,
	[Name] varchar(50) not null
);

create table ItemTypes
(
	ItemTypeID int primary key,
	[Name] varchar(50) not null
);

create table Customers
(
	CustomerId int primary key,
	[Name] varchar(50) not null,
	Birthday date not null,
	CityID int not null foreign key references Cities(CityID)
);

create table Orders
(
	OrderID int primary key,
	CustomerID int not null foreign key references Customers(CustomerID)
);

create table Items
(
	ItemID int primary key,
	[Name] varchar(50) not null,
	ItemTypeID int not null foreign key references ItemTypes(ItemTypeID)
);

create table OrderItems
(
	OrderID int not null foreign key references Orders(OrderID),
	ItemID int not null foreign key references Items(ItemID),
	constraint PK_OrderIems primary key(OrderID, ItemID)
);

-- 06
create database temp
use temp

create table Majors
(
	MajorID int primary key,
	[Name] varchar(50) not null
);

create table Students
(
	StudentID int primary key,
	StudentNumber char(10) not null,
	StudentName varchar(50) not null,
	MajorID int not null foreign key references Majors(MajorId)
);

create table Payments
(
	PaymentID int primary key,
	PaymentDate date not null,
	PaymentAmount decimal(5,2) not null,
	StudentID int foreign key references Students(StudentID)
);

create table Subjects
(
	SubjectID int primary key,
	[Name] varchar(50) not null
);

create table Agenda
(
	StudentID int foreign key references Students(StudentID),
	SubjectID int foreign key references Subjects(SubjectID),
	constraint PK_Agenda primary key(StudentID, SubjectID)
);

-- 09
use Geography
select MountainRange, PeakName, Elevation
from Mountains as m
join Peaks as p
	on p.MountainId = m.Id
where m.MountainRange = 'Rila'
order by Elevation desc

select * from Mountains 
select * from Peaks




