using System;
using System.Linq;
namespace _01_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(GetSmallestNum(nums));
        }
        static int GetSmallestNum(int[] nums)
        {
            int smallest = int.MaxValue;
            foreach (var num in nums)
            {
                if (num<smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
        }
    }
}
