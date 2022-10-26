using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._06.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                names.Add(Console.ReadLine());
            }
            //Console.WriteLine();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
