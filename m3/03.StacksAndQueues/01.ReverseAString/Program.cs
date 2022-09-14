using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> chars = new Stack<char>();

            foreach (var characher in input)
            {
                chars.Push(characher);
            }

            while (chars.Count>0)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}
