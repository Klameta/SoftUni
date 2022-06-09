using System;
using System.Linq;
namespace _05_SumEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var num in nums)
            {
                if (num%2==0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
