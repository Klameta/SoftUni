using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = commandArgs[0];
            int radius = commandArgs[1];
            Console.WriteLine(Explode(nums, bomb, radius));
        }
        static int Explode(List<int> nums, int bomb, int radius)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    if (i - radius >= 0)
                    {
                        nums.RemoveRange(i - radius, radius);
                    }
                    else
                    {
                        for (int k = 0; k < i - 1; k++)
                        {
                            nums.RemoveAt(k);
                        }
                    }
                    int index = nums.IndexOf(bomb);
                    if (radius + 1 < nums.Count)
                    {
                        nums.RemoveRange(index, radius + 1);
                    }
                    else
                    {
                        for (int k = index; k < nums.Count; k++)
                        {
                            nums.RemoveAt(k);
                            k--;
                        }
                    }

                }
            }
            return GetSum(nums);
        }
        private static int GetSum(List<int> nums)
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
