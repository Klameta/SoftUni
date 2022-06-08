using System;

namespace _09_03_Numbers_1_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nInput; i=i+3)
            {
                Console.WriteLine(i);
            }


        }
    }
}
