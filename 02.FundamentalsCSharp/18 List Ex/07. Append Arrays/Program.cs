using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> arrs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int start = 0;
            int index = arrs.IndexOf("|");
            Stack<string> result = new Stack<string>();
            while (index!=-1)
            {
                while (arrs[start]<arrs[index])
                {
                    result.Push(arrs[start]);
                    arrs.RemoveAt(start);
                }
                index = arrs.IndexOf('|');
            }
            Console.WriteLine(string.Join(" ", result));*/
            List<string> strings = Console.ReadLine().Split('|').Reverse().ToList();

            var numbers = new List<int>();
            foreach (var num in strings)
            {
                numbers.AddRange(num.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
