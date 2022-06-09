using System;
using System.Linq;
namespace _05_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bigNum = nums[0];
            string result = "";
            bool bigger = false;
            //27 19 42 2 13 45 48
            foreach (var num in nums)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        bigNum = nums[i];
                    }
                    else if (nums[nums.Length - 1] > bigNum && bigNum == nums[nums.Length - 2])
                    {
                        bigNum = nums[nums.Length - 1];
                    }
                }
                if (bigNum == num)
                {
                    bigger = true;
                    result += num + " ";
                }
            }
            Console.Write(result);
        }
    }
}
