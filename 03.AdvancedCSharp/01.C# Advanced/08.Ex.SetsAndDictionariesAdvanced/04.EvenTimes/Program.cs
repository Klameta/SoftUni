using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbersAppearances = new Dictionary<int, int>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (!numbersAppearances.ContainsKey(currNum))
                {
                    numbersAppearances.Add(currNum, 1);
                }
                else
                {
                    numbersAppearances[currNum]++;
                }
            }

            foreach (var number in numbersAppearances)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
