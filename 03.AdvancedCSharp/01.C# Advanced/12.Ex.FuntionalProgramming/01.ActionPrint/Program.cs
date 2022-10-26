using System;
using System.Linq;
namespace _01.ActionPrint
{
    class Program
    {
        static Action<string[]> newLinePrint = x => Console.WriteLine(string.Join(Environment.NewLine, x));
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            newLinePrint(input);
        }
    }
}
