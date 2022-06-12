using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(MiddleChar(word));
        }
        static string EvenMiddle(string word)
        {
            string first = word[word.Length / 2 - 1].ToString();
            string second = word[word.Length / 2].ToString();
            return first + second;
        }
        static string OddMiddle(string word)
        {
            char first = word[word.Length / 2];
            return first.ToString();
        }
        static string MiddleChar(string word)
        {
            if (word.Length%2==0)
            {
               return EvenMiddle(word);
            }
            else
            {
                return OddMiddle(word);
            }
        }

    }
}
