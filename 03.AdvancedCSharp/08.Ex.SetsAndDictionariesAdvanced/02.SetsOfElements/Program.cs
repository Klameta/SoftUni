using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nAndM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nAndM[0];
            int m = nAndM[1];
            HashSet<int> firstNNums = new HashSet<int>();
            HashSet<int> secondMNums = new HashSet<int>();

            for (int i = 0; i < n+m; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (i<n)
                {
                    firstNNums.Add(currNum);
                }
                else
                {
                    secondMNums.Add(currNum);
                }
            }

            HashSet<int> repeating = new HashSet<int>();
            foreach (var nNum in firstNNums)
            {
                if (secondMNums.Contains(nNum))
                {
                    repeating.Add(nNum);
                }
            }

            Console.WriteLine(string.Join(" ", repeating));
        }
    }
}
