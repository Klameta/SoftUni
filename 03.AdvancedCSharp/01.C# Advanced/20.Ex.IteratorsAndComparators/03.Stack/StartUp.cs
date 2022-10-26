using System;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string[] cmdArgs = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "END")
            {
                switch (cmdArgs[0])
                {
                    case "Push":
                        stack.Push(cmdArgs
                            .Skip(1)
                            .Take(cmdArgs.Length - 1)
                            .ToArray());
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }
                cmdArgs = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }
            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }
        }
    }
}

