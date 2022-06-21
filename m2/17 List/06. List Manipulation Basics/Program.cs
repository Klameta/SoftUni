using System.Linq;
using System.Collections.Generic;
using System;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();
            while (commandArgs[0] != "end")
            {
                switch (commandArgs[0])
                {
                    case "Add":
                        int number = int.Parse(commandArgs[1]);
                        Add(nums, number);
                        break;
                    case "Remove":
                        number = int.Parse(commandArgs[1]);
                        Remove(nums, number);
                        break;
                    case "RemoveAt":
                        int index=int.Parse(commandArgs[1]);
                        RemoveAt(nums, index);
                        break;
                    case "Insert":
                        number = int.Parse(commandArgs[1]);
                        index = int.Parse(commandArgs[2]);
                        Insert(nums, number, index);
                        break;
                }
                commandArgs = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        static void Add(List<int> nums, int num)
        {
            nums.Add(num);
        }
        static void Remove(List<int> nums, int num)
        {
            nums.Remove(num);
        }
        static void RemoveAt(List<int> nums, int index)
        {
            nums.RemoveAt(index);
        }
        static void Insert(List<int> nums, int number, int index)
        {
            nums.Insert(index, number);
        }
    }
}
