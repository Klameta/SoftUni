using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (IsItTop(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DivisableByEight(int number)
        {
            int sum = 0;
            int currentNum = number;
            while (number != 0)
            {
                currentNum = number % 10;
                sum += currentNum;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
        static bool HasOddNumber(int number)
        {
            string numberStr = number.ToString();
            for (int i = 0; i < numberStr.Length; i++)
            {
                if (numberStr[i] == '1' || numberStr[i] == '3' || numberStr[i] == '5' || numberStr[i] == '7' || numberStr[i] == '9')
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsItTop(int number)
        {
            if (DivisableByEight(number) && HasOddNumber(number))
            {
                return true;
            }
            return false;
        }
    }
}
