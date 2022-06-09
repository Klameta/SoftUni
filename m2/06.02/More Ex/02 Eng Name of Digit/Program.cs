using System;
using System.Collections.Generic;
using System.Linq;
namespace _02_Eng_Name_of_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inout = Console.ReadLine();
            var ints = inout.Select(digit => int.Parse(digit.ToString())).ToList();
            int n = ints[ints.Count - 1];
            string st = n == 1
                ? "one" : n == 2
                ? "two" : n == 3
                ? "three" : n == 4
                ? "four" : n == 5
                ? "five" : n == 6
                ? "six" : n == 7
                ? "seven" : n == 8
                ? "eight" : n == 9
                ? "nine" : "zero";
            Console.WriteLine(st);
        }
    }
}
