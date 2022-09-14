using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine()); //'.' = 46
            char secondChar = char.Parse(Console.ReadLine());// '@' = 64
            //'1=49' '2'=50 '5'=53 '6'=54 '5'=53 '3'=51 '5'=53
            int sum = 0;
            string gibberish = Console.ReadLine();
            for (int i = 0; i < gibberish.Length; i++)
            {
                if (gibberish[i]>firstChar&&gibberish[i]<secondChar)
                {
                    sum += gibberish[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
