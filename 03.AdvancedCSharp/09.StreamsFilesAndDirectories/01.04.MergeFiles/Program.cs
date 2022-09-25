using System.IO;
using System;


namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader input1 = new StreamReader(firstInputFilePath);
            using (input1)
            {
                StreamReader input2 = new StreamReader(secondInputFilePath);
                using (input2)
                {
                    StreamWriter writer = new StreamWriter(outputFilePath);
                    using (writer)
                    {

                        while (!input1.EndOfStream & !input2.EndOfStream)
                        {
                            writer.WriteLine(input1.ReadLine());
                            writer.WriteLine(input2.ReadLine());
                        }

                        if (input1.EndOfStream)
                        {
                            WriteExcess(input2, writer);
                        }
                        else if(input2.EndOfStream)
                        {
                            WriteExcess(input1, writer);
                        }
                    }
                }
            }
        }

        private static void WriteExcess(StreamReader input, StreamWriter writer)
        {
            while (!input.EndOfStream)
            {
                writer.WriteLine(input.ReadLine());
            }
        }
    }
}