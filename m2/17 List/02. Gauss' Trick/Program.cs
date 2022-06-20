using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> reals = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.WriteLine(string.Join(" ", Gauss(reals)));
        }
        static List<double> Gauss(List<double> reals)
        {
            for (int i = 0; i < reals.Count; i++)
            {
                if (i != reals.Count - 1)
                {
                    reals[i] = reals[i] + reals[reals.Count - 1];
                    reals.RemoveAt(reals.Count - 1);
                }
            }
            return reals;
        }
    }
}
