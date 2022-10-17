using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _07.CustomComparator
{
    public class StartUp
    {
        public class CustomComparator : IComparer<int>
        {
            public int Compare([AllowNull] int x, [AllowNull] int y)
            {
                if (x % 2 == 0 && Math.Abs(y) % 2 == 1)
                    return -1;
                if (Math.Abs(x) % 2 == 1 && y % 2 == 0)
                    return 1;
                return x.CompareTo(y);
            }
        }
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
