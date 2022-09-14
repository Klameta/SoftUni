using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();
            int countOfCommands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                if (commandArgs.Length == 3)
                {
                    if (people.Contains(commandArgs[0]))
                    {
                        Console.WriteLine($"{commandArgs[0]} is already in the list!");
                    }
                    else
                    {
                        people.Add(commandArgs[0]);
                    }
                }
                else if (commandArgs.Length == 4)
                {
                    if (people.Contains(commandArgs[0]))
                    {
                        people.Remove(commandArgs[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commandArgs[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", people));
        }

    }
}
