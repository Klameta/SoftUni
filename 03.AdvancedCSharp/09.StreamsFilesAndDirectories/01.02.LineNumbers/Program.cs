using System;
using System.IO;
namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);
                int counter = 1;
                using (writer)
                {
                    while (!reader.EndOfStream)
                    {
                        var input = reader.ReadLine();
                        writer.WriteLine($"{counter}. {input}");
                        counter++;
                    }
                }
            }
        }
    }
}
