using System;

namespace _09_04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            for (int i = 0; i <= nInput;i+=2)
            {
                if (i%2==0)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
                
            }


        }
    }
}
