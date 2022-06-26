using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = commandArgs[0];
            int radius = commandArgs[1];
            Console.WriteLine(Explode(nums, bomb, radius));
        }
        static int Explode(List<int> nums, int bomb, int radius)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                List<int> numbersToDelete = new List<int>();

                numbersToDelete.AddRange(nums.FindAll(item => item == bomb));

                for (int j = 0; j < numbersToDelete.Count; j++)
                {
                    int bombIndex = nums.IndexOf(numbersToDelete[j]);

                    if (bombIndex < 0)
                    {
                        break;
                    }

                    nums.RemoveAt(bombIndex);

                    for (int k = 0; k < radius; k++)
                    {
                        if (bombIndex < nums.Count)
                        {
                            nums.RemoveAt(bombIndex);
                        }
                    }

                    for (int m = 0; m < radius; m++)
                    {
                        if (bombIndex - 1 - m >= 0 && bombIndex - 1 - m < nums.Count)
                        {
                            nums.RemoveAt(bombIndex - 1 - m);
                        }
                    }
                }
            }
            return GetSum(nums);
        }
        private static int GetSum(List<int> nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
