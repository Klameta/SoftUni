using System;
using System.Collections.Generic;

namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            int numChecking = 1;

            while (ints.Count < 10)
            {
                try
                {
                    int curr = ReadNumber(numChecking, 100);
                    if (curr != -1)
                    {
                        ints.Add(curr);
                        numChecking=curr;
                    }
                }
                catch (Exception)
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
