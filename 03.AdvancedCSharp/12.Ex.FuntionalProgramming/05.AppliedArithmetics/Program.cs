using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> add = num => ++num;
            Func<int, int> multiply = num => num * 2;
            Func<int, int> subtract = num => --num;

            int[] numsToManipulate = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string cmdArgs = Console.ReadLine();
            while (cmdArgs!="end")
            {
                switch (cmdArgs)
                {
                    case "add":
                        numsToManipulate = numsToManipulate.Select(x => add(x)).ToArray();
                        break;
                    case "multiply":
                        numsToManipulate = numsToManipulate.Select(x => multiply(x)).ToArray();
                        break;
                    case "subtract":
                        numsToManipulate = numsToManipulate.Select(x => subtract(x)).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numsToManipulate));
                        break;
                }
                cmdArgs = Console.ReadLine();
            }
        }
    }
}
