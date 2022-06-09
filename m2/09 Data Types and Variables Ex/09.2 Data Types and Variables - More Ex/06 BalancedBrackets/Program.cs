using System;

namespace _06_BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int openCounter = 0;
            int closedCounter = 0;
            bool balanced = true;
            int doubleBracket = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openCounter++;
                    doubleBracket++;
                }
                else if (input == ")")
                {
                    closedCounter++;
                    doubleBracket--;
                    if (openCounter != closedCounter)
                    {
                        balanced = false;
                    }
                }
            }
            if (!balanced || doubleBracket > 0)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
