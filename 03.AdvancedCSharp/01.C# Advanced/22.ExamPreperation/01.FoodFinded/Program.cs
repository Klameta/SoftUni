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

            Dictionary<char[], List<char>> words = new Dictionary<char[], List<char>>();
            words.Add(new char[] { 'p', 'e', 'a', 'r' }, new List<char>());
            words.Add(new char[] { 'f', 'l', 'o', 'u', 'r' }, new List<char>());
            words.Add(new char[] { 'p', 'o', 'r', 'k' }, new List<char>());
            words.Add(new char[] { 'o', 'l', 'i', 'v', 'e' }, new List<char>());

            while (consonants.Count != 0)
            {
                var currVowel = vowels.Dequeue();
                var currCons = consonants.Pop();
                foreach (var key in words)
                {
                    if (key.Key.Contains(currVowel) && !key.Value.Contains(currVowel))
                    {
                        key.Value.Add(currVowel);
                    }
                    if (key.Key.Contains(currCons) && !key.Value.Contains(currCons))
                    {
                        key.Value.Add(currCons);
                    }
                }

                vowels.Enqueue(currVowel);
            }

            words = words.Where(x => x.Key.Length == x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Words found: {words.Count}");

            foreach (var word in words)
            {
                Console.WriteLine(String.Join("", word.Key));
            }
        }
    }
}
