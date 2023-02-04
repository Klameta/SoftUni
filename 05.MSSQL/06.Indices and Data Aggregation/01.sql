use Gringotts

-- 01
select count(*) as Count
from WizzardDeposits alias;

-- 02
select max(MagicWandSize) as LongestMagicWand
from WizzardDeposits

-- 03

select DepositGroup,max(MagicWandSize) as MagicWandSize
from WizzardDeposits
group by DepositGroup

-- 04
select top(2) DepositGroup
from WizzardDeposits
group by DepositGroup
order by avg(MagicWandSize) asc

-- 05
select DepositGroup, sum(DepositAmount) as TotalSum
from WizzardDeposits
group by DepositGroup

--06
select DepositGroup, sum(DepositAmount) as TotalSum
from WizzardDeposits
where MagicWandCreator = 'Ollivander family'
group by DepositGroup

--07
select DepositGroup, sum(DepositAmount) as TotalSum
from WizzardDeposits
where MagicWandCreator = 'Ollivander family'
group by DepositGroup
having sum(DepositAmount) <150000
order by TotalSum desc

--08
select DepositGroup, MagicWandCreator, min(DepositCharge)
from WizzardDeposits
group by DepositGroup, MagicWandCreator

-- 09
select AgeGroup, count(*) as WizardCount
from(
    select
        case
            when Age <=10 then '[0-10]'
            when age <= 20 then '[11-20]'
            when Age <= 30 then '[21-30]'
            when Age <= 40 then '[31-40]'
            when Age <=50 then '[41-50]'
            when Age <= 60 then '[51-60]'
            else '[61+]'
        end as AgeGroup
    from WizzardDeposits
    ) as a
group by AgeGroup

-- 10
select left(FirstName,1) as FirstLetter
from WizzardDeposits
where DepositGroup = 'Troll Chest'
group by left(FirstName,1)
order by FirstLetter

-- 11
select DepositGroup, IsDepositExpired, avg(DepositInterest) as AverageInterest
from WizzardDeposits
where DepositStartDate > '01-01-1985'
group by DepositGroup, IsDepositExpired
order by DepositGroup desc,
         IsDepositExpired asc;

-- 12
select sum(w1.DepositAmount-w2.DepositAmount) as SumDiffrerence
from WizzardDeposits as w1
join WizzardDeposits as w2
on w1.Id = w2.Id - 1;

-- 13
use SoftUni

select DepartmentID,sum(Salary) as TotalSalary
from Employees
group by DepartmentID

-- 14
select DepartmentID, min(Salary) as MinimunSalary
from Employees
where DepartmentID in (2,5,7)
    and HireDate>'01-01-2000'
group by DepartmentID;

-- 15
select * into NewEmployees
from Employees
where Salary>30000;

delete
    from NewEmployees
where ManagerID=42;

update NewEmployees
    set Salary+=5000
where DepartmentID=1;

select DepartmentID, avg(Salary) as AverageSalary
from NewEmployees
group by DepartmentID;

-- 16
select DepartmentID, max(Salary) as MaxSalary
from Employees
group by DepartmentID
having max(Salary) <30000
or max(Salary) > 70000


-- 17
select count(*) Count
from Employees
where ManagerID is null;

-- 19



select *
from Departments;






