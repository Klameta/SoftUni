using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split();
            while (commandArgs[0] != "End")
            {
                switch (commandArgs[0])
                {
                    case "Add":
                        int number = int.Parse(commandArgs[1]);
                        Add(nums, number);
                        break;
                    case "Remove":
                        int index = int.Parse(commandArgs[1]);
                        if (CheckIndex(nums, index))
                        {
                            Remove(nums, index);
                        }
                        break;
                    case "Insert":
                        number = int.Parse(commandArgs[1]);
                        index = int.Parse(commandArgs[2]);
                        if (CheckIndex(nums, index))
                        {
                            Insert(nums, number, index);
                        }
                        break;
                    case "Shift":
                        int times = int.Parse(commandArgs[2]);
                        if (commandArgs[1] == "left")
                        {
                            ShiftLeft(nums, times);
                        }
                        else
                        {
                            ShiftRight(nums, times);
                        }
                        break;
                }
                commandArgs = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        static void Add(List<int> nums, int number)
        {
            nums.Add(number);
        }
        static void Remove(List<int> nums, int index)
        {
            nums.RemoveAt(index);
        }
        static void Insert(List<int> nums, int number, int index)
        {
            nums.Insert(index, number);
        }
        static bool CheckIndex(List<int> nums, int index)
        {
            if (index >= nums.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return false;
            }
            return true;
        }
        static void ShiftLeft(List<int> nums, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Add(nums, nums[0]);
                Remove(nums, 0);
            }
        }
        static void ShiftRight(List<int> nums, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Insert(nums, nums[nums.Count - 1], 0);
                Remove(nums, nums.Count - 1);
            }
        }
    }
}
