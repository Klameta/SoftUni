using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, string, bool> lessThanFilter = (filter, name) => name.Length <= filter;

            int filter = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => lessThanFilter(filter, x))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
