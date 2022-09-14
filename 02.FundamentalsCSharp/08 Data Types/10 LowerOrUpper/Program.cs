using System;

namespace _10_LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            string result = letter == letter.ToLower() ? "lower-case" : "upper-case";

            Console.WriteLine(result);
        }
    }
}
