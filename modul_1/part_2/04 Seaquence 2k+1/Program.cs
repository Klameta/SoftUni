using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Seaquence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var seaquence = 1;
            while (n>seaquence)
            {
                Console.WriteLine(seaquence);

                seaquence = seaquence * 2 + 1;
            }

        }
    }
}
