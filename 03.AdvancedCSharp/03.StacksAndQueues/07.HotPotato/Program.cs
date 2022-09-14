using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> names = new Queue<string>();

            foreach (var kid in kids)
            {
                names.Enqueue(kid);
            }

            int counter = 1;
            string temp = string.Empty;
            while (names.Count != 1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    temp = names.Dequeue();
                    names.Enqueue(temp);
                }
                Console.WriteLine($"Removed {names.Dequeue()}");
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
