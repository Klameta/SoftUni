using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < lines; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
