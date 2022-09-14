using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";
            string customers = Console.ReadLine();
            double income = 0;
            StringBuilder people = new StringBuilder();
            while (customers!="end of shift")
            {
                MatchCollection validCustomers = Regex.Matches(customers, regex);
                foreach (Match customer in validCustomers)
                {
                    string name = customer.Groups["name"].Value;
                    string product = customer.Groups["product"].Value;
                    int quanitity = int.Parse(customer.Groups["count"].Value);
                    double price = double.Parse(customer.Groups["price"].Value);
                    double currSum = quanitity * price;
                    income += currSum;
                    people.AppendLine($"{name}: {product} - {currSum:F2}");
                }
                customers = Console.ReadLine();
            }
            Console.WriteLine(people + $"Total income: {income:F2}");
        }
    }
}
