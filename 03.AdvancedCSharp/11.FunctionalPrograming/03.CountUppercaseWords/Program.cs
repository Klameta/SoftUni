using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] upperCases = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.First() == x.ToUpper().First())
                .ToArray();

            Console.WriteLine(string.Join("\n", upperCases));
        }
    }
}
