using SoftUni.Data;
using System.Globalization;
using System.Text;
using SoftUni.Models;
using System.Diagnostics;
using System.Linq;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();
            string output = RemoveTown(context);
            Console.WriteLine(output);
        }
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var employeesInfo = context.Employees
                .Select(e => new { e.EmployeeId, e.FirstName, e.MiddleName, e.LastName, e.JobTitle, e.Salary })
                .OrderBy(e => e.EmployeeId);

            StringBuilder sb = new StringBuilder();
            foreach (var employee in employeesInfo)
            {
                sb.AppendLine($"{employee.FirstName}" +
                    $" {employee.LastName}" +
                    $" {employee.MiddleName}" +
                    $" {employee.JobTitle}" +
                    $" {employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employeesInfo = context.Employees
                .Select(e => new { e.FirstName, e.Salary })
                .Where(e => e.Salary > 50_000)
                .OrderBy(e => e.FirstName)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var employee in employeesInfo)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employeesInfo = context.Employees
                .Select(e => new { e.FirstName, e.LastName, e.Department, e.Salary })
                .Where(e => e.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary);

            StringBuilder sb = new StringBuilder();
            foreach (var employee in employeesInfo)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Department.Name} - ${employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();

        }
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            string newAdressInfo = "Vitoshka 15";
            int townId = 4;

            var newAdressEntity = new Address()
            {
                AddressText = newAdressInfo,
                TownId = townId
            };

            context.Addresses.Add(newAdressEntity);
            context.SaveChanges();

            var employee = context.Employees
                .Where(e => e.LastName == "Nakov")
                .FirstOrDefault();

            employee.Address = newAdressEntity;
            context.SaveChanges();

            string[] employeesAdressesText = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => (string)e.Address.AddressText)
                .Take(10)
                .ToArray();

            return string.Join(Environment.NewLine, employeesAdressesText);
        }
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var EmployeeInfo = context.Employees
                .Take(10)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects.Where(ep => ep.Project.StartDate.Year >= 2001 & ep.Project.StartDate.Year <= 2003)
                        .Select(ep => new
                        {
                            ProjectName = ep.Project.Name,
                            StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                            EndDate = ep.Project.EndDate != null
                                ? ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                                : "not finished"
                        })
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var e in EmployeeInfo)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");

                if (e.Projects.Any())
                {
                    sb.AppendLine(String.Join(Environment.NewLine, e.Projects
                        .Select(p => $"--{p.ProjectName} - {p.StartDate} - {p.EndDate}")));
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addressesInfo = context.Addresses
                .Select(a => new
                {
                    a.AddressText,
                    TownName = a.Town.Name,
                    EmployeeCount = a.Employees.Count
                })
                .OrderByDescending(a => a.EmployeeCount)
                .ThenBy(a => a.TownName)
                .ThenBy(a => a.AddressText)
                .Take(10);

            StringBuilder sb = new StringBuilder();
            foreach (var address in addressesInfo)
            {
                sb.AppendLine($"{address.AddressText}, {address.TownName} - {address.EmployeeCount} employees");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployee147(SoftUniContext context)
        {
            var employee = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.EmployeesProjects
                        .Select(ep => new { ProjectName = ep.Project.Name })
                        .OrderBy(ep => ep.ProjectName)
                        .ToList()
                })
                .FirstOrDefault();


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            sb.AppendLine(string.Join(Environment.NewLine, employee.Projects.Select(ep => ep.ProjectName)));

            return sb.ToString().TrimEnd();
        }
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departmentInfo = context.Departments
                .Select(d => new
                {
                    EmployeesCount = d.Employees.Count,
                    d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    Employees = d.Employees
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .Select(e => new
                    {
                        EmployeeData = $"{e.FirstName} {e.LastName} - {e.JobTitle}"
                    })
                })
                .Where(d => d.EmployeesCount > 5)
                .OrderBy(d => d.EmployeesCount)
                .ThenBy(d => d.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var department in departmentInfo)
            {
                sb.AppendLine($"{department.Name} - {department.ManagerFirstName} {department.ManagerLastName}");
                sb.AppendLine(string.Join(Environment.NewLine, department.Employees.Select(e => e.EmployeeData)));
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetLatestProjects(SoftUniContext context)
        {
            var projectInfo = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    Date = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                });

            StringBuilder sb = new StringBuilder();
            foreach (var project in projectInfo)
            {
                sb.AppendLine($"{project.Name}{Environment.NewLine}{project.Description}{Environment.NewLine}{project.Date}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            string[] departments = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };
            var employeesInDepartments = context.Employees
                .Where(d => departments.Contains(d.Department.Name))
                .ToList();

            foreach (var e in employeesInDepartments)
            {
                e.Salary *= 1.12M;
            }

            context.SaveChanges();

            var employeesInfo = context.Employees
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Where(e => departments.Contains(e.Department.Name))
                .Select(e => new { EmployeeInfo = $"{e.FirstName} {e.LastName} (${e.Salary:F2})" })
                .ToList();

            return string.Join(Environment.NewLine, employeesInfo.Select(e => e.EmployeeInfo));
        }
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            string startingLetters = "sa";
            var employeesInfo = context.Employees
                .Where(e => e.FirstName.ToLower().StartsWith(startingLetters))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new { EmployeeInfo = $"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})" })
                .ToList();

            return string.Join(Environment.NewLine, employeesInfo.Select(e => e.EmployeeInfo));
        }
        public static string DeleteProjectById(SoftUniContext context)
        {
            var projectIdToDelete = 2;
            var employeesProjectsToDelete = context.EmployeesProjects
                .Where(ep => ep.ProjectId == projectIdToDelete);
            context.EmployeesProjects.RemoveRange(employeesProjectsToDelete);

            var projectToDelete = context.Projects
                .Where(p => p.ProjectId == projectIdToDelete)
                .FirstOrDefault();
            context.Projects.Remove(projectToDelete);

            context.SaveChanges();

            var projectInfo = context.Projects
                .Take(10)
                .Select(p => p.Name);

            return string.Join(Environment.NewLine, projectInfo);
        }
        public static string RemoveTown(SoftUniContext context)
        {
            string townName = "Seattle";

            var townToDelete = context.Towns
                .Where(t => t.Name == townName)
                .FirstOrDefault();

            var addressesToDelete = context.Addresses
                .Where(a => a.Town.Name == townName)
                .ToList();
            var employeesAddressesToNull = context.Employees
                .Where(e => addressesToDelete
                .Contains(e.Address))
                .ToArray();

            foreach (var employee in employeesAddressesToNull)
            {
                employee.Address = null;
            }

            context.RemoveRange(addressesToDelete);
            context.Towns.Remove(townToDelete);
            context.SaveChanges();

            return $"{addressesToDelete.Count} addresses in Seattle were deleted";
        }

    }
}