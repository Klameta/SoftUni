using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsWithPeople = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] commandArgs = Console.ReadLine().Split();
            while (commandArgs[0]!="end")
            {
                switch (commandArgs[0])
                {
                    case "Add":
                        int passengers = int.Parse(commandArgs[1]);
                        AddWagon(wagonsWithPeople, passengers, capacity);
                    break;
                    default:
                        passengers = int.Parse(commandArgs[0]);
                        AddPassengers(wagonsWithPeople, passengers, capacity);
                        break;
                }
                commandArgs = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ",wagonsWithPeople));

        }
        static void AddWagon(List<int> wagonsWithPeople, int wagon, int capacity)
        {
            if (wagon <= capacity)
            {
                wagonsWithPeople.Add(wagon);
            }
        }
        static void AddPassengers(List<int> wagonsWithpeople, int passengers, int capacity)
        {
            for (int i = 0; i < wagonsWithpeople.Count; i++)
            {
                if (wagonsWithpeople[i] + passengers <= capacity)
                {
                    wagonsWithpeople[i] += passengers;
                    break;
                }
            }
        }

    }
}
