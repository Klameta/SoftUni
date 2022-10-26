using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();

            foreach (var num in inputNums)
            {
                nums.Push(num);
            }

            string[] commandArgs = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            while (commandArgs[0] != "end")
            {
                switch (commandArgs[0])
                {
                    case "add":
                        Add(nums, commandArgs);
                        break;
                    case "remove":
                        Remove(nums, commandArgs);

                        break;
                }
                commandArgs = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            }
            int sum = 0;
            while (nums.Count > 0)
            {
                sum += nums.Pop();
            }
            Console.WriteLine($"Sum: {sum}");

        }

        private static void Remove(Stack<int> nums, string[] commandArgs)
        {
            int num = int.Parse(commandArgs[1]);
            if (nums.Count > num)
            {

                for (int i = 0; i < num; i++)
                {
                    nums.Pop();
                }
            }
        }

        private static void Add(Stack<int> nums, string[] commandArgs)
        {
            int num1 = int.Parse(commandArgs[1]);
            int num2 = int.Parse(commandArgs[2]);

            nums.Push(num1);
            nums.Push(num2);
        }
    }
}
