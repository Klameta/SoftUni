using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split();
            while(commandArgs[0]!="end")
            {
                switch (commandArgs[0])
                {
                    case "Delete":
                        int num = int.Parse(commandArgs[1]);
                        Delete(nums, num);
                        break;
                    case "Insert":
                        num = int.Parse(commandArgs[1]);
                        int index = int.Parse(commandArgs[2]);
                        Insert(nums, num, index);
                        break;
                }
                commandArgs = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        static void Delete(List<int> nums, int num)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]==num)
                {
                    nums.RemoveAt(i);
                }
            }
        }
        static void Insert(List<int> nums, int num, int index)
        {
            nums.Insert(index, num);
        }
    }
}
