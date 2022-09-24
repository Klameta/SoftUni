using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elements = new HashSet<string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var cmd in cmdArgs)
                {
                    elements.Add(cmd);
                }
            }
            Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
