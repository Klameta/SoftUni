using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> leftBrackets = new Stack<char>();
            int currIndex = 0;
            bool endOfArr = false;


            while (input[currIndex]!= ')' && input[currIndex] != ']' && input[currIndex] != '}' && !endOfArr)
            {
                CheckIfIndexIsBeyondArrLenght(input, ref currIndex, ref endOfArr);
                char leftBracket = input[currIndex-1];
                leftBrackets.Push(leftBracket);

            }

            bool balanced = true;
            CheckIfIndexIsBeyondArrLenght(input, ref currIndex, ref endOfArr);

            while (balanced && !endOfArr && leftBrackets.Count>0)
            {
                char currBracket = leftBrackets.Pop();

                if (currBracket== '{' && input[currIndex-1]!='}') 
                {
                    balanced = false;
                }
                else if (currBracket=='[' && input[currIndex-1]!=']')
                {
                    balanced = false;
                }
                else if (currBracket=='(' && input[currIndex-1]!=')')
                {
                    balanced = false;
                }
                CheckIfIndexIsBeyondArrLenght(input,ref currIndex,ref endOfArr);
            }

            if (balanced && leftBrackets.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static void CheckIfIndexIsBeyondArrLenght(char[] input, ref int currIndex, ref bool endOfArr)
        {
            if (currIndex == input.Count() - 1)
            {
                endOfArr = true;
            }
            else
            {
                currIndex++;
            }
        }
    }
}
