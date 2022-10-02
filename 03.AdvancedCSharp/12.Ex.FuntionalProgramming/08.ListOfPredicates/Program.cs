using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> divisable = (curNum, divider) => curNum % divider == 0;
            Func<int[], int, List<int>> divisableList = (nums, MaxNum) =>
              {
                  List<int> result = new List<int>();

                  for (int i = 1; i <= MaxNum; i++)
                  {
                  bool valid = true;
                      foreach (var div in nums)
                      {
                          if (!divisable(i, div))
                          {
                              valid = false;
                          }
                      }
                      if (valid)
                      {
                          result.Add(i);
                      }
                  }
                  return result;
              };
            int maxNums = int.Parse(Console.ReadLine());
            int[] diveders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> divisableResult = divisableList(diveders, maxNums);

            Console.WriteLine(string.Join(" ", divisableResult));
        }
    }
}
