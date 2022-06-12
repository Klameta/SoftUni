using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandargs = Console.ReadLine().Split();

            while (commandargs[0] != "end")
            {
                switch (commandargs[0])
                {
                    case "exchange":
                        int index = int.Parse(commandargs[1]);
                        if (index > nums.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums = Exchange(nums, index);
                        }
                        break;
                    case "max":
                        if (commandargs[1] == "odd")
                        {
                            index = MaxOdd(nums);
                            NoMatchesMax(index);
                        }
                        else //even max
                        {
                            index = MaxEven(nums);
                            NoMatchesMax(index);
                        }
                        break;
                    case "min":
                        if (commandargs[1] == "even")
                        {
                            index = MinEven(nums);
                            NoMatchesMin(index);
                        }
                        else
                        {
                            index = MinOdd(nums);
                            NoMatchesMin(index);
                        }
                        break;
                    case "first":
                        index = int.Parse(commandargs[1]);
                        if (index >= nums.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }


                        if (commandargs[2] == "even")
                        {
                                int[] resultNums = FirstEvenNums(nums, index);
                                FirstLastResult(resultNums);
                        }
                        else if (commandargs[2] == "odd")
                        {
                            int[] resultNums = FirstOddNums(nums, index);
                            FirstLastResult(resultNums);
                        }
                        break;
                    case "last":
                        index = int.Parse(commandargs[1]);
                        if (index >= nums.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (commandargs[2] == "even")
                        {
                            int[] resultNums = LastEvenNums(nums, index);
                            FirstLastResult(resultNums);
                        }
                        else if (commandargs[2] == "odd")
                        {
                            int[] resultNums = LastOddNums(nums, index);
                            FirstLastResult(resultNums);
                        }
                        break;
                }
                commandargs = Console.ReadLine().Split();
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        private static void FirstLastResult(int[] resultNums)
        {
            if (resultNums.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", resultNums) + "]");
            }
        }
        private static void NoMatchesMin(int index)
        {
            if (index == int.MaxValue || index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        private static void NoMatchesMax(int index)
        {
            if (index == int.MinValue || index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static int[] Exchange(int[] nums, int index)
        {
            int[] firstArr = new int[index + 1];
            int[] secondArr = new int[nums.Length - (index + 1)];
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= index)
                {
                    firstArr[i] = nums[i];
                }
                else
                {
                    secondArr[counter] = nums[i];
                    counter++;
                }
            }
            return secondArr.Concat(firstArr).ToArray();
        }
        static int MaxEven(int[] nums)
        {
            int biggest = int.MinValue;
            foreach (var num in nums)
            {
                if (num > biggest && num % 2 == 0)
                {
                    biggest = num;
                }
            }
            return Array.LastIndexOf(nums, biggest);
        }
        static int MaxOdd(int[] nums)
        {
            int biggest = int.MinValue;
            foreach (var num in nums)
            {
                if (num > biggest && num % 2 == 1)
                {
                    biggest = num;
                }
            }
            return Array.LastIndexOf(nums, biggest);
        }
        static int MinEven(int[] nums)
        {
            int smallest = int.MaxValue;
            foreach (var num in nums)
            {
                if (num < smallest && num % 2 == 0)
                {
                    smallest = num;
                }
            }
            return Array.LastIndexOf(nums, smallest);
        }
        static int MinOdd(int[] nums)
        {
            int smallest = int.MaxValue;
            foreach (var num in nums)
            {
                if (num < smallest && num % 2 == 1)
                {
                    smallest = num;
                }
            }
            return Array.LastIndexOf(nums, smallest);
        }
        static int[] FirstEvenNums(int[] nums, int index)
        {
            int[] result = new int[index];
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                if (nums[i] % 2 == 0 && count < result.Length)
                {
                    result[count] = nums[i];
                    count++;
                }
            }
            return result;
        }
        static int[] FirstOddNums(int[] nums, int index)
        {
            int[] result = new int[index];
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                if (nums[i] % 2 == 1 && count < result.Length)
                {
                    result[count] = nums[i];
                    count++;
                }
            }
            return result;
        }
        static int[] LastEvenNums(int[] nums, int index)
        {
            int[] evens = new int[nums.Length - 1];
            int count = 0;
            for (int i = 0; i < nums.Length; i++) //collect all evens
            {
                if (nums[i] % 2 == 0)
                {
                    evens[count] = nums[i];
                    count++;
                }
            }

            if (evens.Sum() == 0)
            {
                Array.Resize(ref evens, 0);
                return evens;
            }
            count = 0;
            int[] result = new int[index];
            for (int i = nums.Length - index; i < nums.Length; i++)
            {
                result[count] = evens[i];
            }

            return result;
        }
        static int[] LastOddNums(int[] nums, int index)
        {
            int[] odds = new int[nums.Length - 1];
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    odds[count] = nums[i];
                    count++;
                }
            }//collect all odds

            count = 0;
            int[] result = new int[index];
            for (int i = index - nums.Length; i < nums.Length; i++)
            {
                result[count] = odds[i];
            } //collect the last odds

            return result;
        }

    }
}

