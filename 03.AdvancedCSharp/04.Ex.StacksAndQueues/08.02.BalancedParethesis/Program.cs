using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02.BalancedParethesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char>  leftBrackets= new Stack<char>();
            bool valid = true;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '{':
                    case '[':
                    case '(':
                        leftBrackets.Push(input[i]);
                        break;
                    default:
                        if (input[i] =='}')
                        {
                            if (leftBrackets.Pop()!='{')
                            {
                                valid = false;
                            }
                        }
                        else if (input[i] == ']')
                        {
                            if (leftBrackets.Pop() != ']')
                            {
                                valid = false;
                            }
                        }
                        else if (input[i] == ')')
                        {
                            if (leftBrackets.Pop() != ')')
                            {
                                valid = false;
                            }
                        }
                        break;

                }

            }
        }

    }
}
