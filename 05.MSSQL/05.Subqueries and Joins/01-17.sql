-- 01
Select  top(5) e.EmployeeID, e.JobTitle, a.AddressID, a.AddressText
from Employees as e
join Addresses as A
    on e.AddressID = A.AddressID
order by a.AddressID

-- 02
select top(50) e.FirstName, e.LastName, t.Name as Town, a.AddressText
from Addresses as a
join Towns as t
    on a.TownID = t.TownID
join Employees e
    on a.AddressID = e.AddressID
order by FirstName, LastName

-- 03
select e.EmployeeID, e.FirstName, e.LastName, d.Name as DepartmentName
from Employees as e
join Departments d
    on d.DepartmentID = e.DepartmentID
where d.Name = 'Sales'
order by EmployeeID

-- 04
select top(5) e.EmployeeID, e.FirstName, e.Salary,d.Name as DepartmentName
from Employees as e
join Departments d
    on d.DepartmentID = e.DepartmentID
where e.Salary > 15000
order by d.DepartmentID

-- 05
select top(3) e.EmployeeID, e.FirstName
from Employees as e
left join EmployeesProjects ep
    on e.EmployeeID = ep.EmployeeID
where ep.EmployeeID is null
order by e.EmployeeID

--06
select e.FirstName, e.LastName, e.HireDate, d.Name as DeptName
from Employees as e
join Departments d
    on d.DepartmentID = e.DepartmentID
where e.HireDate > '1999-01-01'
  and d.Name in ('Sales', 'Finance')
order by HireDate asc

-- 07
select top(5) e.EmployeeID,FirstName, p.Name as ProjectName
from Employees as e
join EmployeesProjects ep
    on e.EmployeeID = ep.EmployeeID
join Projects p
    on p.ProjectID = ep.ProjectID
where p.StartDate >'2002-08-13'
  and p.EndDate is null
order by e.EmployeeID asc

-- 08
select e.EmployeeID, FirstName, cast(
    case
        when year(p.StartDate) >= 2005 then NULL
    else p.Name
    end
    as varchar(50)
    )
from Employees as e
join EmployeesProjects EP
    on e.EmployeeID = EP.EmployeeID
join Projects P
    on P.ProjectID = EP.ProjectID
where e.EmployeeID = 24

-- 09
select e.EmployeeID, e.FirstName, e.ManagerID, m.FirstName as ManagerName
from Employees as e
join Employees as m
    on e.ManagerID = m.EmployeeID
where m.EmployeeID in (3,7)
order by e.EmployeeID

-- 10

















