using SoftUni.Data;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();
            string output = GetEmployeesWithSalaryOver50000(context);
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
    }
}