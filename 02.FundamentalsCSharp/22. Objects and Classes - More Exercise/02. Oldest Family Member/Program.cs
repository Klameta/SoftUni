using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                Person person = new Person(commandArgs[0], int.Parse(commandArgs[1]));
                family.AddPerson(person);
            }
            Console.WriteLine(family.GetOldestPerson());
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Family
    {
        public List<Person> People = new List<Person>();
        public void AddPerson(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestPerson()
        {
            List<Person> temp = People.OrderByDescending(x=>x.Age).ToList();
            return temp[0];
        }
    }

}
