using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static Func<int[], int> findingMin = nums => nums.Min();
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(findingMin(nums));
        }
    }
}
