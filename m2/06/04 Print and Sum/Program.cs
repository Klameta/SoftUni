using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var sum = 0;
            var list = new List<int>();

            for (int i = n1; i <= n2; i++)
            {
                list.Add(i);
                sum += i;
            }
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
