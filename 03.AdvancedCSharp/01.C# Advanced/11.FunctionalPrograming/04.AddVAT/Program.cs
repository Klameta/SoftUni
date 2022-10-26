using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AddVAT
{
    class Program
    {
        static Func<string,string > addingVAT = x => $"{double.Parse(x) * 1.20D:F2}";
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine,
                Console.ReadLine()
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => addingVAT(x))
                .ToArray()));
        }

    }
}
