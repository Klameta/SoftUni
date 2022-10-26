using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static Action<string[]> knighting = x => Console.WriteLine(string.Join(Environment.NewLine, x.Select(x => $"Sir {x}").ToArray()));
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            knighting(names);
        }
    }
}
