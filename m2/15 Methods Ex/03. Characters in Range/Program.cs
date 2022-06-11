using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            char[] result = GetCharsInRange(first, second);
            Console.WriteLine(string.Join(" ", result));
        }
        static char[] GetCharsInRange(char first, char second)
        {
            char[] chars = new char[Math.Abs(first - second) - 1];
            if (first < second)
            {
                int j = 0;
                for (int i = first + 1; i < second; i++)
                {
                    chars[j] = (char)i;
                    j++;
                }
            }
            else
            {
                int j = 0;
                for (int i = second + 1; i < first; i++)
                {
                    chars[j] = (char)i;
                    j++;
                }
            }
            return chars;
        }
    }
}
