using System;
using System.Collections.Generic;
using System.Linq;
namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandargs = Console.ReadLine();
            while (commandargs!="END")
            {
                Polindrome(int.Parse(commandargs));
                commandargs = Console.ReadLine();
            }
        }
        static bool EvenPolindrome(int number)
        {
            string numberSt = number.ToString();
            string firstHalf = "";
            string secondHalf = "";
            int counter = 1;
            for (int i = 0; i < numberSt.Length; i++)
            {
                if (i < numberSt.Length / 2)
                {
                    firstHalf += numberSt[i];
                }
                else
                {
                    CheckForSecondhalf(numberSt, ref secondHalf, ref counter);
                }
            }

            return IsItEaqual(firstHalf, secondHalf);
        }

        static void Polindrome(int number)
        {
            string numberstr = number.ToString();
            if (numberstr.Length % 2 == 0)
            {
                Console.WriteLine(EvenPolindrome(number).ToString().ToLower());
            }
            else
            {
                Console.WriteLine(OddPolindrome(number).ToString().ToLower());
            }
        }
        static bool OddPolindrome(int number)
        {
            string numebrStr = number.ToString();
            string firstHalf = "";
            string secondHalf = "";
            int counter = 1;
            for (int i = 0; i < numebrStr.Length-1; i++)
            {
                if (i < numebrStr.Length / 2)
                {
                    firstHalf += numebrStr[i];
                }
                else
                {
                    CheckForSecondhalf(numebrStr, ref secondHalf, ref counter);
                }
            }
            return IsItEaqual(firstHalf,secondHalf);
        }

        private static void CheckForSecondhalf(string numebrStr, ref string secondHalf, ref int counter)
        {
            secondHalf += numebrStr[numebrStr.Length - counter];
            counter++;
        }
        private static bool IsItEaqual(string firstHalf, string secondHalf)
        {
            if (firstHalf == secondHalf)
            {
                return true; 
            }
            return false;
        }

    }
}
