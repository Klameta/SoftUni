using System;
using System.IO;
namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] info = dir.GetFiles("*", SearchOption.AllDirectories);
            decimal sum = 0;

            foreach (var inf in info)
            {
                sum += inf.Length;
            }

            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                writer.WriteLine(sum / 1024);
            }

        }
    }
}
