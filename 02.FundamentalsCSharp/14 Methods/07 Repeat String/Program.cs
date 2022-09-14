using System;

namespace _07_Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            int timesRepeated = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeating(letters, timesRepeated));
        }
        static string Repeating(string letters, int timesRepeated)
        {
            string result = "";
            for (int i = 0; i < timesRepeated; i++)
            {
                result += letters;
            }
            return result;
        }
    }
}
