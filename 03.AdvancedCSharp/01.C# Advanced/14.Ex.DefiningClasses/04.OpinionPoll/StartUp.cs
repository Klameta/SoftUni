using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                people.Add(person);
            }

            people = people.Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
