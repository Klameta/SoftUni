using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = (x) => x % 2 == 0;
            Predicate<int> odd = (x) => x % 2 == 1 || x % 2 == -1;

            int[] startEnd = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = startEnd[0];
            int end = startEnd[1];
            string filter = Console.ReadLine();
            List<int> result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (filter == "odd" && odd(i))
                {
                    result.Add(i);
                }
                if (filter == "even" && even(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
