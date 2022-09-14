using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = Console.ReadLine().ToList();
            list.Reverse();
            Console.WriteLine(String.Join("", list));
        }
    }
}
