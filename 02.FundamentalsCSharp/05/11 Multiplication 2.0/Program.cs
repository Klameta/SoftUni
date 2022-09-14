using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Multiplication_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num2 > 10)
            {
                Console.WriteLine($"{num} X {num2} = {num * num2}");
            }
            else
            {
                for (; num2 < 11; num2++)
                {
                    Console.WriteLine($"{num} X {num2} = {num * num2}");

                }
            }
        }
    }
}
