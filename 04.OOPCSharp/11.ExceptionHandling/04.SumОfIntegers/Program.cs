using System;
using System.Xml.Linq;

namespace _04.SumОfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int sum = 0;
            string currElement = "";
            int currNum = 0;
            foreach (var num in nums)
            {
                try
                {
                    currElement = num;
                    currNum = int.Parse(num);
                    sum+=currNum;
                }
                catch (Exception ex)
                {
                    if (ex.GetType().Name == "FormatException")
                    {
                        Console.WriteLine($"The element '{currElement}' is in wrong format!");
                    }
                    else if (ex.GetType().Name == "OverflowException")
                    {
                        Console.WriteLine($"The element '{currElement}' is out of range!");
                    }

                }
                finally
                {
                    Console.WriteLine($"Element '{currElement}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
