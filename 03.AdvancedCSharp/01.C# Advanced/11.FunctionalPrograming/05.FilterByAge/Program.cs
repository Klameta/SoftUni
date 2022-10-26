using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        public static Func<Person, string, int, bool> ageFilter = (person, condition, age) => condition == "older" ?
        person.Age >= age :
        person.Age < age;

        public static Func<Person, string[], string> formatting = (person, formater) =>
       {
           if (formater.Length == 2)
           {
               return formater[0] == "name" ? $"{person.Name} - {person.Age}" : $"{person.Age} - {person.Name}";
           }
           return formater[0] == "name" ? $"{person.Name}" : $"{person.Age}";
       };

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            people = people
                .Where(x => ageFilter(x, condition, age))
                .ToList();

            string[] formater = Console.ReadLine().Split();

            Console.WriteLine(string.Join(Environment.NewLine, people.Select(x => formatting(x,formater))));
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
