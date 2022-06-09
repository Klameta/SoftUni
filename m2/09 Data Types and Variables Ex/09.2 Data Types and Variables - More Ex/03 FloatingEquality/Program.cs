using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            var diff = Math.Abs(num1 -num2);
            string diffStr = diff.ToString();
            int index = diffStr.IndexOf("."); //find where "." is
            if (index == -1)//if there's no "."
            {
                Console.WriteLine("False");
            }
            else //if there is "."
            {
                diffStr = diffStr.TrimStart(diffStr[0]).TrimEnd(diffStr[index]); //remove everything before "."
                if (diffStr.Length > 7) //.000_001.Lenght = 7 
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
