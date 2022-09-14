using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] commandArgs = Console.ReadLine().Split();

            while (commandArgs[0]!="end")
            {
                Student student = new Student(commandArgs[0], commandArgs[1], int.Parse(commandArgs[2]),commandArgs[3]);
                students.Add(student);
                commandArgs = Console.ReadLine().Split();
            }
            string command = Console.ReadLine();
            students =students.Where(x => x.Town == command).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Student(string firstName, string lastName, int age, string town)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Town = town;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
