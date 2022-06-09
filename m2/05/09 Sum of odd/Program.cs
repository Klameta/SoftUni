using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sum_of_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0;
            var odd = 1;
            for (int i = 0; i < count; i++)
            {
                sum += odd;
                Console.WriteLine(odd);
                odd += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
