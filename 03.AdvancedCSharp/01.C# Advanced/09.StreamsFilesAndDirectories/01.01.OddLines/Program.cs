using System;
using System.IO;
namespace OddLines
{
    public class OddLines
    {
        static void Main() { string inputFilePath = @"..\..\..\Files\input.txt"; string outputFilePath = @"..\..\..\Files\output.txt"; ExtractOddLines(inputFilePath, outputFilePath); }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = 0;

                StreamWriter streamWriter = new StreamWriter(outputFilePath);
                using (streamWriter)
                {
                    while (!reader.EndOfStream)
                    {
                        var input = reader.ReadLine();
                        if (counter % 2 == 1)
                        {
                            streamWriter.WriteLine(input);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
