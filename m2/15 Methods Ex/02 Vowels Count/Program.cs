using System;
using System.Linq;
namespace _02_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(GetVowelsCount(word));
        }
        static int GetVowelsCount(string word)
        {
            string smallWord = word.ToLower();
            int count = 0;
            foreach (char letter in smallWord)
            {
                if (letter=='a'||letter=='e'||letter=='i'||letter=='o'||letter=='u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
