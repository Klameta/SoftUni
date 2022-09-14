using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._01_Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bigCount = Math.Max(first.Count, second.Count);
            List<int> result = new List<int>();

            for (int i = 0; i < bigCount; i++)
            {
                if (first.Count > i)
                {
                    result.Add(first[i]);
                }

                if (second.Count > i)
                {
                    result.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }
        static List<int> Merge(List<int> first, List<int> second)
        {
            int bigCount = Math.Max(first.Count, second.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < bigCount; i++)
            {
                if (first.Count > i)
                {
                    result.Add(first[i]);
                }

                if (second.Count > i)
                {
                    result.Add(second[i]);
                }
            }
            return result;
        }

    }
}
