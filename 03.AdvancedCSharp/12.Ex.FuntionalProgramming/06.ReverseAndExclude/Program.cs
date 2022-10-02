using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> divisable = (currNum, divader) => currNum % divader !=0;

            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int divider = int.Parse(Console.ReadLine());

            nums = nums
                .Reverse()
                .Where(x => divisable(x, divider))
                .ToArray();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
