using System;
using System.Text;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Square(number));
        }
        static string Lines(int number)
        {
            string result = "";
            for (int i = 0; i < number; i++)
            {
                result += number.ToString() + " ";
            }
            return result;
        }
        static string Square(int number)
        {
            string lines = Lines(number);

            string result = "";
            for (int i = 0; i < number; i++)
            {
                result += lines + $"\n";
            }
            return result;
        }

    }
}
