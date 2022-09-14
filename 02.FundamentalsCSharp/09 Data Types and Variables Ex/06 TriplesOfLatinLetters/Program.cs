using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Triplets0fNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    for (int k = 0; k < n; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.Write($"{firstChar}{secondChar}{thirdChar}"); ;
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}