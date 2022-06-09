using System.Linq;
using System;

namespace _06_EvenoddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            foreach (var num in nums)
            {
                if (num%2==0)
                {
                    evenSum+=num;
                }
                else
                {
                    oddSum += num;
                }
            }

            Console.WriteLine(evenSum-oddSum);
        }
    }
}
