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
            Stack<string[]> commands = new Stack<string[]>();

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
                        string temp = "2 " + manipulatedText.Substring(manipulatedText.Length - 3+1);
                        commands.Push(temp.Split(' ').ToArray());

                        int count = int.Parse(cmdArgs[1]);
                        manipulatedText = manipulatedText.Remove(manipulatedText.Length - count);
                        break;
                    case "3":
                        int index = int.Parse(cmdArgs[1]);
                        Console.WriteLine(manipulatedText[index - 1]);
                        break;
                    case "4":
                        cmdArgs = commands.Pop();
                        if (cmdArgs[0] == "1")
                        {
                            manipulatedText = manipulatedText.Remove(manipulatedText.Length - cmdArgs[1].Length);
                        }
                        else
                        {
                            manipulatedText += cmdArgs[1];
                        }
                        break;
                }
            }
        }
    }
}
