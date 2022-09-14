using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            bool numOrSign = false;
            Stack<string> operations = new Stack<string>();

            foreach (var str in input)
            {
                operations.Push(str);
            }

            int sum = int.Parse(operations.Pop());
            string sign = "";
            int num = 0;
            while (operations.Count > 0)
            {
                sign = operations.Pop();

                num = int.Parse(operations.Pop());

                if (sign == "-")
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
