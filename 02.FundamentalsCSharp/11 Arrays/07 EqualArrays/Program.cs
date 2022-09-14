using System;
using System.Linq;
namespace _07_EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i]!=nums2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sum+=nums2[i];
                    counter++;
                }
            }

            if (counter==nums1.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
