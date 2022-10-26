using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            DateTime first = new DateTime(info[0], info[1], info[2]);

            info = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            DateTime second = new DateTime(info[0], info[1], info[2]);
            TimeSpan result = first - second;

            Console.WriteLine(Math.Abs(result.Days));
        }
    }
}
