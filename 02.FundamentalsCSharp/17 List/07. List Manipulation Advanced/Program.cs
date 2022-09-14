using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandArgs = Console.ReadLine().Split().ToArray();
            bool changedList = false;
            while (commandArgs[0] != "end")
            {
                switch (commandArgs[0])
                {
                    case "Add":
                        int number = int.Parse(commandArgs[1]);
                        Add(nums, number);
                        changedList = true;
                        break;
                    case "Remove":
                        number = int.Parse(commandArgs[1]);
                        Remove(nums, number);
                        changedList = true;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(commandArgs[1]);
                        RemoveAt(nums, index);
                        changedList = true;
                        break;
                    case "Insert":
                        number = int.Parse(commandArgs[1]);
                        index = int.Parse(commandArgs[2]);
                        Insert(nums, number, index);
                        changedList = true;
                        break;
                    case "Contains":
                        number = int.Parse(commandArgs[1]);
                        if (!nums.Contains(number))
                        {
                            Console.WriteLine("No such number");
                        }
                        else
                        {
                            Console.WriteLine("Yes");
                        }
                        break;
                    case "PrintEven":
                        PrintEven(nums);
                        break;
                    case "PrintOdd":
                        PrintOdd(nums);
                        break;
                    case "GetSum":
                        GetSum(nums);
                        break;
                    case "Filter":
                        string condition = commandArgs[1];
                        number = int.Parse(commandArgs[2]);
                        Filter(nums, condition, number);
                        break;
                }
                commandArgs = Console.ReadLine().Split();
            }
            if (changedList)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
        static void PrintEven(List<int> nums)
        {
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOdd(List<int> nums)
        {
            foreach (var num in nums)
            {
                if (num % 2 == 1)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
        static void GetSum(List<int> nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
        static void Filter(List<int> nums, string condition, int num)
        {
            switch (condition)
            {
                case "<":
                    foreach (var number in nums)
                    {
                        if (number < num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;
                case ">":
                    foreach (var number in nums)
                    {
                        if (number > num)
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    break;
                case ">=":
                    foreach (var number in nums)
                    {
                        if (number >= num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;
                case "<=":
                    foreach (var number in nums)
                    {
                        if (number <= num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;
            }
            Console.WriteLine();
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
