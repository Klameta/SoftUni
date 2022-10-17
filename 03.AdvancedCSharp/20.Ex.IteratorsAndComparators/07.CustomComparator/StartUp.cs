using System;
using System.Linq;

namespace _07.CustomComparator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var comparer = new CustomComparator();
            Array.Sort(nums, comparer);

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
