
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int exceptions = 0;
            while (exceptions < 3)
            {
                try
                {
                    string[] cmdArgs = Console.ReadLine().Split();

                    switch (cmdArgs[0])
                    {
                        case "Replace":
                            int index = int.Parse(cmdArgs[1]);
                            int element = int.Parse(cmdArgs[2]);

                            nums[index] = element;
                            break;
                        case "Print":
                            int startIndex = int.Parse(cmdArgs[1]);
                            int endIndex = int.Parse(cmdArgs[2]);

                            if (startIndex<0||endIndex>=nums.Count)
                            {
                                throw new ArgumentOutOfRangeException();
                            }

                            Console.WriteLine(String.Join(", ", nums
                                .Skip(startIndex)
                                .Take(endIndex - startIndex + 1)));
                            break;
                        case "Show":
                            index = int.Parse(cmdArgs[1]);
                            Console.WriteLine(nums[index]);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    switch (ex.GetType().Name)
                    {
                        case "ArgumentOutOfRangeException":
                            Console.WriteLine("The index does not exist!");
                            break;
                        case "FormatException":
                            Console.WriteLine("The variable is not in the correct format!");
                            break;
                    }
                    exceptions++;
                }

            }
                Console.WriteLine(String.Join(", ", nums));

        }
    }
}
