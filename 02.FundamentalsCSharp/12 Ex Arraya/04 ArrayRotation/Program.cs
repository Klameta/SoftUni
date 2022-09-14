using System;
using System.Linq;
namespace _04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                //51 47 32 61 21
                //0  1  2  3  4

                for (int k = 1; k < nums.Length; k++) //51 47 32 61 21
                {
                    int tempNum = nums[k - 1];
                    nums[k - 1] = nums[k];
                    nums[k] = tempNum;

                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
