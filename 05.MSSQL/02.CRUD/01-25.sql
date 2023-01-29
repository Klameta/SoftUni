use SoftUni
-- 02
select * from Departments

-- 03
Select Name from Departments

-- 04
select FirstName, LastName, Salary
from Employees 

-- 05
select FirstName, MiddleName, LastName
from Employees

-- 06
select CONCAT(e.FirstName,'.', e.LastName,'@softuni.bg') as 'Full Email Address'
from Employees as e

-- 07
select distinct(Salary)
from Employees
order by Salary

-- 08
select *
from Employees
where JobTitle = 'Sales Representative'

-- 09
select FirstName, LastName, JobTitle
from Employees
where Salary >= 20000
	and Salary <=  30000

-- 10
select concat(e.FirstName, ' ',e.MiddleName, ' ' ,e.LastName) as 'Full Name'
from Employees as e
where Salary =  25000
	or Salary = 14000
	or Salary = 12500
	or Salary = 23600

-- 11
select FirstName, LastName
from Employees
where ManagerID is null

-- 12
select FirstName, LastName, Salary
from Employees
where Salary >50000
order by salary desc

-- 13
select top(5) FirstName, LastName
from Employees
order by Salary desc

--14
select FirstName, LastName
from Employees
where DepartmentID <> 4

-- 15
select *
from Employees
order by Salary desc,
		FirstName asc,
		LastName desc,
		MiddleName asc;
go;
--16
create view V_EmployeesSalaries as
	select FirstName, LastName, Salary
	from Employees
	
-- 17
create view V_EmployeeNameJobTitle as
select concat(FirstName, ' ',cast(
		case when MiddleName is null
			then ''
			else MiddleName
			end as varchar(50)), ' ', LastName) as 'FullName'
			, JobTitle
from Employees

--18
select distinct JobTitle
from Employees

-- 19
select top(10)  *
from Projects
where StartDate is not null
order by StartDate,
		Name

-- 20
select top(7) FirstName, LastName, HireDate 
from Employees
order by HireDate desc

-- 21
update Employees
set Salary *= 1.12
where DepartmentID in (1, 2,4,11)

select salary
from Employees

--22
use Geography

select PeakName
from Peaks
order by PeakName 

-- 23
select top(30) CountryName, [Population]
from Countries
where ContinentCode = 'EU'
order by [Population] desc,
		 CountryName asc

-- 24
select CountryName, CountryCode, (case 
									when CurrencyCode = 'EUR' then 'Euro'
									else 'Not Euro'
									end) as 'Currency'
from Countries
order by CountryName asc

-- 25
select [Name]
from Characters
order by [Name] asc

select * from Characters






select * from Departments
select * from Projects








