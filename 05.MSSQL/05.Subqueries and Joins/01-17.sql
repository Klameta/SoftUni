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
use SoftUni
select top(50) e.EmployeeID, e.FirstName + ' ' + e.LastName as EmployeeName
             , m.FirstName + ' ' + m.LastName as ManagerName
             , d.Name as DepartmentName
from Employees as e
join Employees as m
    on e.ManagerID = m.EmployeeID
join Departments d
    on d.DepartmentID = e.DepartmentID
order by e.EmployeeID

-- 11
select min(a.AverageSalary) as MinAverageSalary
from
(
    select avg(e.Salary) as AverageSalary
    from Employees as e
    group by e.DepartmentID

) as a

-- 12
use Geography

select c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
from Peaks as p
join Mountains as m
    on p.MountainId = m.Id
join MountainsCountries MC
    on m.Id = MC.MountainId
join Countries C
    on C.CountryCode = MC.CountryCode
where c.CountryName = 'Bulgaria'
    and p.Elevation > 2835
order by p.Elevation desc

-- 13

select c.CountryCode, count(m.Id) as MountainRanges
from Countries as c
join MountainsCountries MC
    on c.CountryCode = MC.CountryCode
join Mountains as m
    on MC.MountainId = m.Id
where c.CountryCode in ('BG', 'RU', 'US')
group by c.CountryCode

-- 14

select top(5) c.CountryName, r.RiverName
from Countries as c
left join CountriesRivers as cr
    on c.CountryCode = cr.CountryCode
left join Rivers R
    on cr.RiverId = R.Id
where c.ContinentCode = 'AF'
order by c.CountryName

-- 16
select count(c.CountryCode) as 'Count'
from Countries as c
left join MountainsCountries as mc
    on c.CountryCode = mc.CountryCode
where mc.CountryCode is null

-- 17
select top(5)c.CountryName,
       max(p.Elevation) as HighestPeakElevation,
       max(r.Length) as LongestRiverLength
from Countries as c
join MountainsCountries MC
    on c.CountryCode = MC.CountryCode
join Mountains M
    on M.Id = MC.MountainId
join Peaks P
    on M.Id = P.MountainId
join CountriesRivers CR
    on c.CountryCode = CR.CountryCode
join Rivers R
    on R.Id = CR.RiverId
group by c.CountryName
order by HighestPeakElevation desc,
         LongestRiverLength desc



select *
from ;













