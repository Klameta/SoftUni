using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evens = new Queue<int>();

            foreach (var num in input)
            {
                if (num%2==0)
                {
                    evens.Enqueue(num);
                }
            }

                Console.WriteLine(string.Join(", ", evens));
        }
    }
}
