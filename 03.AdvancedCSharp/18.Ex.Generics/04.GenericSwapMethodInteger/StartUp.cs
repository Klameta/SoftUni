using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Box<int>> nums = new List<Box<int>>();

            for (int i = 0; i < lines; i++)
            {
                nums.Add(new Box<int>(int.Parse(Console.ReadLine())));
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Swap(nums, indexes[0], indexes[1]);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        static void Swap<T>(List<Box<T>> values, int firstIndex, int secondIndex)
        {
            (values[firstIndex], values[secondIndex]) = (values[secondIndex], values[firstIndex]);
        }
    }
}
