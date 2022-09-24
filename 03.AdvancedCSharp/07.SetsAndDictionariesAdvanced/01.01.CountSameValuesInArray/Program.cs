using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _01._01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> valuesCount = new Dictionary<double, int>();
            double[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            for (int i = 0; i < cmdArgs.Length; i++)
            {
                if (!valuesCount.ContainsKey(cmdArgs[i]))
                {
                    valuesCount.Add(cmdArgs[i], 1);
                }
                else
                {
                    valuesCount[cmdArgs[i]]++;
                }
            }

            foreach (var value in valuesCount)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
