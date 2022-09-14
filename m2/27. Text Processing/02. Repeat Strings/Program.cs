using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
           
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                foreach (var letter in word)
                {
                    result.Append(word);
                }

            }
            Console.WriteLine(result);
        }
    }
}
