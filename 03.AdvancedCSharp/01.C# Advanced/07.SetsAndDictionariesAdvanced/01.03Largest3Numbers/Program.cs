using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._03Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));

            Console.WriteLine(string.Join(" ", new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList()).OrderByDescending(x => x).Take(3)));
        }
    }
}
