Selec * from Towns;
Select * from Departments;
select * from Employees;

-- 02
Select * from Towns as t
order by t.Name asc;

Select * from Departments as d
order by d.Name asc;

select * from Employees as e
order by e.Salary desc;

-- 03
select [Name] from Towns
order by Name;
select [Name] from Departments
order by Name asc;
select e.FirstName, e.LastName, e.JobTitle, e.Salary from Employees as e
order by e.Salary desc;

-- 04
UPDATE [Employees]
	SET [Salary] *= 1.1

SELECT [Salary] FROM [Employees]

-- 05
DELETE [Occupancies]





