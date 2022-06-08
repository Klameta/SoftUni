using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            if (nInput==0)
            {
                Console.WriteLine("No");
            }
            else if (nInput>=-100 && nInput<=100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
