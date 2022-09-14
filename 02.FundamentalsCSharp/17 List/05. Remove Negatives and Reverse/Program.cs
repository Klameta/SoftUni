using System.Collections.Generic;
using System;
using System.Linq;
namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Combined(nums);
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
        static void Combined(List<int> nums)
        {
            RemovingNegs(nums);
            nums.Reverse();
        }
        static void RemovingNegs(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }
        }
    }
}
