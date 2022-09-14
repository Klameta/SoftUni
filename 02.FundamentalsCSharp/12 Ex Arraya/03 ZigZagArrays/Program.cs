using System;
using System.Linq;

namespace _03_ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] odds = new int[nLines];
            int[] evens = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evens[i] = input[0];
                    odds[i] = input[1];
                }
                else
                {
                    evens[i] = input[1];
                    odds[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(" ", evens));
            Console.WriteLine(string.Join(" ", odds));
        }
    }
}
