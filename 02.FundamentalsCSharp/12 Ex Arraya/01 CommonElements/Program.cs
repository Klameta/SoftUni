using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _02_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            foreach (var str in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i]==str)
                    {
                        Console.Write($"{arr1[i]} ");
                    }
                }
            }
        }

    }
}
