using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01EnergyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> mgCaffeine = new Stack<int>();
            Queue<int> energyDrinks = new Queue<int>();

            int[] numsFirst = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] numsSecond = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numsFirst.Length; i++)
            {
                mgCaffeine.Push(numsFirst[i]);
            }
            for (int i = 0; i < numsSecond.Length; i++)
            {
                energyDrinks.Enqueue(numsSecond[i]);
            }

            int totalCaffeine = 0;
            int max = 300;


            while (true)
            {
                if (mgCaffeine.Count == 0 || energyDrinks.Count == 0) //break
                {
                    break;
                }

                int currDrink = mgCaffeine.Peek() * energyDrinks.Peek();

                if (currDrink + totalCaffeine <= max)
                {
                    totalCaffeine += currDrink;
                    mgCaffeine.Pop();
                    energyDrinks.Dequeue();
                }
                else
                {
                    mgCaffeine.Pop();
                    var temp = energyDrinks.Dequeue();
                    energyDrinks.Enqueue(temp);
                    if (totalCaffeine >= 30)
                    {
                        totalCaffeine -= 30;
                    }
                }

            }

            if (energyDrinks.Count>0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");
        }
    }
}
