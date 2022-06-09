using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleToGetIn = int.Parse(Console.ReadLine());
            List<int> lifts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < lifts.Count; i++)
            {
                while (lifts[i]<4 && peopleToGetIn>0)
                {
                    peopleToGetIn--;
                    lifts[i]++;
                }
            }

            if (peopleToGetIn>0)
            {
                Console.WriteLine($"There isn't enough space! {peopleToGetIn} people in a queue!");
                Console.WriteLine(String.Join(" ", lifts));
            }
            else if (lifts[lifts.Count-1] <4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lifts));
            }
            else
            {
                Console.WriteLine(String.Join(" ", lifts));
            }
        }
    }
}
