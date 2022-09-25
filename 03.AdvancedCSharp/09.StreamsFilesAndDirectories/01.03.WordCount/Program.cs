using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader wordReader = new StreamReader(wordsFilePath);
            int index = 0;
            int currCounter = 0;
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            using (wordReader)
            {
                string[] wordTokens = wordReader.ReadToEnd().Split();
                foreach (var wordToken in wordTokens)
                {
                    wordCount.Add(wordToken, 1);
                }

                StreamReader textReader = new StreamReader(textFilePath);
                using (textReader)
                {
                    string[] text = textReader.ReadToEnd().Split().Select(x => x.ToLower()).ToArray();
                    foreach (var word in text)
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                    }
                }
            }

            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            using (streamWriter)
            {
                wordCount = wordCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var word in wordCount)
                {
                    streamWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
