using System;
using System.Linq;

namespace _04.Froggy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int[] pond = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Frog ints = new Frog(pond);
            Console.WriteLine(string.Join(", ", ints));
        }
    }
}
