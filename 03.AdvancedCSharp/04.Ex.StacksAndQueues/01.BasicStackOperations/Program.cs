using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = cmd[0];
            int toPop = cmd[1];
            int toSearch = cmd[2];

            Stack<int> nums = new Stack<int>();
            int[] numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            foreach (var num in numArr)
            {
                nums.Push(num);
            }

            for (int i = 0; i < toPop; i++)
            {
                nums.Pop();
            }

            if (nums.Count() <= 0)
            {
                Console.WriteLine(0);
            }
            else if (nums.Contains(toSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
