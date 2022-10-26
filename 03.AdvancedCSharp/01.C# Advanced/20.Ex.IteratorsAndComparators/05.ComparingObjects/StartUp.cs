using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "END")
            {
                Person person = new Person(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                people.Add(person);

                cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            int indexPerson = int.Parse(Console.ReadLine()) - 1;
            int counterMatches = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[indexPerson].CompareTo(people[i]) == 0)
                {
                    counterMatches++;
                }
            }

            if (counterMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{counterMatches} {people.Count - counterMatches} {people.Count}");
            }

        }
    }
}
