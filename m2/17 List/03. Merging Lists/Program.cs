using System.Collections.Generic;
using System.Linq;
using System;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> second = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.WriteLine(string.Join(" ", Merge(first,second)));
        }
        static List<double> Merge(List<double> first, List<double> second)
        {
            int length = first.Count + second.Count;
            List<double> result = new List<double>(new double[length]);
            int counterF = 0;
            int counterS = 0;
            bool finishedF = false;
            bool finishedS = false;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    if (counterF < first.Count)
                    {
                        result[i] = first[counterF];
                        counterF++;
                    }
                    else
                    {
                        finishedF = true;
                    }

                    if (finishedS)
                    {
                        result[i] = first[counterF];
                        counterF++;
                    }
                }
                else
                {
                    if (counterS<second.Count)
                    {
                        result[i] = second[counterS];
                        counterS++;
                    }
                    else
                    {
                        finishedS = true;
                    }

                    if (finishedF)
                    {
                        result[i] = second[counterS];
                        counterS++;
                    }
                }
            }
            return result;
        }
    }
}
