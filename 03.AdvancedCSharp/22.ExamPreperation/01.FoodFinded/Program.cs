using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.FoodFinded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>();
            Stack<char> consonants = new Stack<char>();

            char[] inputVowels = Console.ReadLine()
                                        .Split(' ')
                                        .Select(char.Parse)
                                        .ToArray();
            char[] inputConsanats = Console.ReadLine()
                                           .Split(' ')
                                           .Select(char.Parse)
                                           .ToArray();

            foreach (var vowel in inputVowels)
            {
                vowels.Enqueue(vowel);
            }
            foreach (var constant in inputConsanats)
            {
                consonants.Push(constant);
            }

            Dictionary<string, List<char>> words = new Dictionary<string, List<char>>();

            while (consonants.Count != 0)
            {
                var currVowel = vowels.Dequeue();
                var currCons = consonants.Pop();


            }
        }
    }
}
