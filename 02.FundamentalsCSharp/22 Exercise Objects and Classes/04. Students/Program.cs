using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                Student student = new Student(commandArgs[0], commandArgs[1], double.Parse(commandArgs[2]));
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string fname, string lname, double grade)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Grade = grade;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}
