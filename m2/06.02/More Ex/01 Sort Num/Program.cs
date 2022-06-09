using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _01_Sort_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(int.Parse(Console.ReadLine()));
            list.Add(int.Parse(Console.ReadLine()));
            list.Add(int.Parse(Console.ReadLine()));

            list.Sort();
            list.Reverse();
            Console.WriteLine(String.Join($"\n", list));
        }
    }
}
