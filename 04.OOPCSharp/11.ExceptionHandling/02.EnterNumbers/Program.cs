using System;
using System.Collections.Generic;

namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            while (ints.Count < 10)
            {
                try
                {
                    int curr = ReadNumber(1, 100);
                    if (curr != -1) ints.Add(curr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Number!");
                }

            }


            Console.WriteLine(String.Join(", ", ints));
        }
        public static int ReadNumber(int start, int end)
        {
            int currNum = int.Parse(Console.ReadLine());

            if (currNum <= start || currNum >= end)
            {
                Console.WriteLine($"Your number is not in range {start} - {end}!");
                return -1;
            }
            return currNum;
        }
    }
}
