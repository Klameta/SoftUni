using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", usernames));
        }
    }
}
