-- 01
select FirstName, LastName
from Employees
where FirstName like 'Sa%'

-- 02
select FirstName, LastName
from Employees
where LastName like '%ei%'

-- 03
select FirstName
from Employees
where DepartmentID in (3,10)
	and HireDate >= '1995-01-01'
	and HireDate <= '2005-12-31'

-- 04
select FirstName, LastName
from Employees
where JobTitle not like '%engineer%'

-- 05
select [Name]
from Towns 
where  len([Name]) in (5,6) 
order by [Name]

-- 06
select TownID, [Name]
from Towns
where [Name] like 'M%'
			or [Name] like 'K%'
			or [Name] like 'B%'
			or [Name] like 'E%'
order by [Name]

-- 07
select TownID, [Name]
from Towns
where [Name] not like 'R%'
			AND [Name] not like 'B%'
			AND [Name] not like 'D%'
order by [Name]
go;

-- 08
create view V_EmployeesHiredAfter2000 as
select FirstName, LastName
from Employees
where HireDate > '2000-12-31';

-- 09
select FirstName, LastName
from Employees
where Len(LastName) = 5

-- 10

