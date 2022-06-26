using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Space_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] route = Console.ReadLine().Split("||").ToArray();
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < route.Length; i++)
            {
                string[] commandArgs = route[i].Split();
                switch (commandArgs[0])
                {
                    case "Travel":
                        int years = int.Parse(commandArgs[1]);
                        Travel(years,ref fuel);
                        break;
                    case "Enemy":
                        int armour = int.Parse(commandArgs[1]);
                        Enemy(armour,ref  ammunition,ref fuel);
                        break;
                    case "Repair":
                        int amount = int.Parse(commandArgs[1]);
                        Repair(amount,ref fuel,ref ammunition);
                        break;
                    case "Titan":
                        Titan();
                        break;
                }
            }
        }
        static void Travel(int years,ref int fuel)
        {
            if (fuel<years)
            {
                MissionFailed();
            }
            Console.WriteLine($"The spaceship travelled {years} light-years.");
            fuel -= years;
        }
        static void Enemy(int armour, ref int ammuntion,ref int fuel)
        {
            if (ammuntion >= armour)
            {
                ammuntion -= armour;
                Console.WriteLine($"An enemy with {armour} armour is defeated.");
            }
            else if (armour * 2 <=fuel)
            {
                fuel -= armour * 2;
                Console.WriteLine($"An enemy with {armour} armour is outmaneuvered.");
            }
            else
            {
                MissionFailed();
            }
        }
        static void Repair(int amount,ref  int fuel,ref int ammunition)
        {
            fuel += amount;
            ammunition += amount * 2;
            Console.WriteLine($"Ammunitions added: {amount*2}.");
            Console.WriteLine($"Fuel added: {amount}.");
        }
        static void Titan()
        {
            Console.WriteLine("You have reached Titan, all passengers are safe.");
            Environment.Exit(0);
        }
        private static void MissionFailed()
        {
            Console.WriteLine($"Mission failed.");
            Environment.Exit(0);
        }
    }
}
