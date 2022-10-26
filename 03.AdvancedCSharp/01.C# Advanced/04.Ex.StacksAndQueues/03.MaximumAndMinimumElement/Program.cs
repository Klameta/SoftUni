using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < lines; i++)
            {
                int[] cmndArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (cmndArgs[0])
                {
                    case 1:
                        int push = cmndArgs[1];
                        nums.Push(push);
                        break;
                    case 2:
                        if (nums.Count>0)
                        {
                        nums.Pop();
                        }
                        break;
                    case 3:
                        if (nums.Count>0)
                        {
                        Console.WriteLine(nums.Max());
                        }
                        break;
                    case 4:
                        if (nums.Count>0)
                        {
                        Console.WriteLine(nums.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
