using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace EvenLines
{

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader inputReader = new StreamReader(inputFilePath))
            {
                int counter = 0;
                while (!inputReader.EndOfStream)
                {
                    if (counter % 2 == 0)
                    {
                        sb.AppendLine(inputReader.ReadLine());
                        ReplaceCharsWithAt(sb);
                        sb
                    }
                    else
                    {
                        inputReader.ReadLine();
                    }

                    counter++;
                }
            }

        }
        public static void ReplaceCharsWithAt(StringBuilder sb)
        {
            char[] separators = new char[] { '-', ',', '.', '!', '?' };
            foreach (var seperator in separators)
            {
                sb.Replace(seperator, '@');
            }
        }

        public static string Reverse(StringBuilder sb)
        {
            string result = string.Empty;
            foreach (var line in sb)
            {
                sb.
            }
        }
    }
}
