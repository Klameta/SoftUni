using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                int indexOfStartName = input.IndexOf($"@");
                int indexOfEndName = input.IndexOf("|");
                string name = input.Substring(indexOfStartName + 1, indexOfEndName - indexOfStartName-1);
                int indexOfStartAge = input.IndexOf('#');
                int indexOfEndAge = input.IndexOf("*");
                string age = input.Substring(indexOfStartAge + 1, indexOfEndAge - indexOfStartAge-1);
                people.Add(new Person(name, age));
            }
            Console.WriteLine(string.Join("\n", people));
        } 
    }
    class Person
    {
        public string Age { get; set; }
        public string Name { get; set; }
        public Person(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} is {this.Age} years old.";
        }
    }
}
