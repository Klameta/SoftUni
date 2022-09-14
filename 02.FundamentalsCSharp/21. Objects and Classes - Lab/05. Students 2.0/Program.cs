using System;
using System.Collections.Generic;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string commandargs = Console.ReadLine();

                if (commandargs == "end")
                {
                    break;
                }

                string[] splited = commandargs.Split();

                if (IsStudentExisting(splited[0], splited[1], students))
                {
                    Student student = students.Find(student => student.FirstName == splited[0] && student.LastName == splited[1]);
                    student.Age = int.Parse(splited[2]);
                    student.Town = splited[3];
                }
                else
                {
                    Student student = new Student(splited[0], splited[1], int.Parse(splited[2]), splited[3]);
                    students.Add(student);
                }
            }

            string command = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Town == command)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(string firstName, string lastName, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Town = town;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
}