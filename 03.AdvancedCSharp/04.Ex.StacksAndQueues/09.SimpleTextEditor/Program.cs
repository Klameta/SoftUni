using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string manipulatedText = string.Empty;
            Stack<string[]> commands = new Stack<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');
                switch (cmdArgs[0])
                {
                    case "1":
                        commands.Push(cmdArgs);
                        manipulatedText += cmdArgs[1];
                        break;
                    case "2":
                        commands.Push(cmdArgs);
                        int count = int.Parse(cmdArgs[1]);
                        for (int к = 0; к < count; к++)
                        {
                            manipulatedText = manipulatedText.Remove(manipulatedText.Last());
                        }
                        break;
                    case "3":
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine(manipulatedText[index]);
                        break;
                    case "4":

                        break;
                }
            }
        }
    }
}
