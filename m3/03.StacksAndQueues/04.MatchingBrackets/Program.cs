using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<int> indexes = new Stack<int>();
            List<string> brackets = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int indexOfOpening = indexes.Pop();
                    for (int k = indexOfOpening; k <= i; k++)
                    {
                        brackets.Add(input[k].ToString());
                    }
                    brackets.Add("\n");
                }
            }
            Console.WriteLine(string.Join("", brackets));
        }
    }
}
