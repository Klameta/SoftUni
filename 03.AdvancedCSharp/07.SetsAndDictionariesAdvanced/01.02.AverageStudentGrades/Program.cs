using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!studentGrades.ContainsKey(cmdArgs[0]))
                {
                    studentGrades.Add(cmdArgs[0], new List<decimal>());
                    studentGrades[cmdArgs[0]].Add(decimal.Parse(cmdArgs[1]));
                }
                else
                {
                    studentGrades[cmdArgs[0]].Add(decimal.Parse(cmdArgs[1]));
                }
            }

            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.Write($"(avg: {student.Value.Average():F2})");
                Console.WriteLine();
            }
        }
    }
}
