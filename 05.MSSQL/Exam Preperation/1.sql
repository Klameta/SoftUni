create database Zoo;
go;
use Zoo
create table Owners
(
    Id int identity primary key,
    Name varchar(50) not null,
    PhoneNumber varchar(15) not null,
    Address varchar(50)
)

create table AnimalTypes
(
  Id int identity primary key ,
  AnimalType varchar(30) not null
)

create table Cages
(
    Id int identity primary key ,
    AnimalTypeId int not null foreign key references AnimalTypes(Id)
)

create table Animals
(
  id int identity primary key,
  Name varchar(30) not null,
  Birthdate date not null,
  OwnerId int foreign key references Owners(Id),
  AnimalTypeId int not null foreign key references AnimalTypes(Id)
)

create table AnimalsCages
(
    CageId int not null foreign key references Cages(Id),
    AnimalId int not null foreign key references  Animals(Id),
    primary key (CageId, AnimalId)
)

create table VolunteersDepartments
(
    Id int identity primary key ,
    DepartmentName varchar(30) not null
)

create table Volunteers
(
    Id int identity primary key,
    Name varchar(50) not null,
    PhoneNumber varchar(15) not null,
    Address varchar(50),
    AnimalId int foreign key references Animals(Id),
    DepartmentId int not null foreign key references VolunteersDepartments(Id)
)



