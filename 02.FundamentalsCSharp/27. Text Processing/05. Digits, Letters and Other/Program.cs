using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] gibberish = Console.ReadLine().ToCharArray();
            string numbers = string.Empty;
            string letters = string.Empty;
            string unique = string.Empty;
            foreach (var letter in gibberish)
            {
                if (char.IsDigit(letter))
                {
                    numbers += letter;
                }
                else if (char.IsLetter(letter))
                {
                    letters += letter;
                }
                else
                {
                    unique += letter;
                }
            }
            Console.WriteLine($"{numbers}\n{letters}\n{unique}");
        }

    }
}
