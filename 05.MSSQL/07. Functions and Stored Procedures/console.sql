use SoftUni
create procedure usp_GetEmployeesSalaryAbove35000
as
    select FirstName, LastName
    from Employees
    where Salary> 35000

-- 02
create procedure  usp_GetEmployeesSalaryAboveNumber
(@salary decimal(18, 4))
    as
    select FirstName,LastName
    from Employees
    where Salary>=@salary

exec usp_GetEmployeesSalaryAboveNumber 48100

-- 03

create procedure usp_GetTownsStartingWith
(@town varchar(50))
as
    select Name
    from Towns
    where left(lower(Name), len(@town)) = lower(@town)


exec usp_GetTownsStartingWith be

-- 04

create procedure  usp_GetEmployeesFromTown
(@town varchar(50))
as
    select FirstName, LastName
    from Employees
    join Addresses A on A.AddressID = Employees.AddressID
    join Towns T on T.TownID = A.TownID
    where t.Name = @town

-- 05
create function ufn_GetSalaryLevel(@salary DECIMAL(18,4))
returns varchar(50)
as
begin
    return case
        when(@salary <30000) then 'Low'
        when(@salary<=50000) then 'Average'
        else 'High'
        end
end

select Salary, dbo.ufn_GetSalaryLevel(Salary) as Level
from Employees

-- 06
create proc usp_EmployeesBySalaryLevel(@level varchar(10))
as
select FirstName,LastName
from Employees
    where dbo.ufn_GetSalaryLevel(Salary) = @level ;




