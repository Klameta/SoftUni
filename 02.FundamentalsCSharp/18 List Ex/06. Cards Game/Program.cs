using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (first.Count > 0 && second.Count > 0)
            {
                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.Add(second[0]);
                }
                else if (first[0] < second[0])
                {
                    second.Add(second[0]);
                    second.Add(first[0]);
                }
                    first.Remove(first[0]);
                    second.Remove(second[0]);
                if (first.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {GetSum(second)}");
                    break;
                }
                else if (second.Count==0)
                {
                    Console.WriteLine($"First player wins! Sum: {GetSum(first)}");
                    break;
                }
            }
        }
        static int GetSum(List<int> nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
