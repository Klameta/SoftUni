using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charTimes = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                if (!charTimes.ContainsKey(letter))
                {
                    charTimes.Add(letter, 1);
                }
                else
                {
                    charTimes[letter]++;
                }
            }

            foreach (var occurence in charTimes)
            {
                Console.WriteLine($"{occurence.Key}: {occurence.Value} time/s");
            }
        }
    }
}
