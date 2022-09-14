using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);
                string currentWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
