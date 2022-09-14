using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string commandArgs = Console.ReadLine();
            int lines = 0;
            StringBuilder sb = new StringBuilder();
            while (commandArgs != "find")
            {
                int counter = 0;
                for (int i = 0; i < commandArgs.Length; i++)
                {
                    if (counter >= key.Length)
                    {
                        counter = 0;
                    }
                    sb.Append((char)(commandArgs[i] - key[counter]));
                    counter++;
                }
                sb.AppendLine();
                lines++;
                commandArgs = Console.ReadLine();
            }
            List<Ore> ores = new List<Ore>();
            string[] stringLines = sb.ToString().Split('\n','\r',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stringLines.Length; i++)
            {
                string decoded = stringLines[i];
                int indexOfStartType = decoded.IndexOf($"&");
                int indexOfEndType = decoded.LastIndexOf("&");
                string type = decoded.Substring(indexOfStartType + 1, indexOfEndType - indexOfStartType - 1);

                int indexOfStartCords = decoded.IndexOf('<');
                int indexOfEndCords = decoded.IndexOf(">");
                string cords = decoded.Substring(indexOfStartCords + 1, indexOfEndCords - indexOfStartCords - 1);

                ores.Add(new Ore(type, cords));
                sb.Remove(0, indexOfEndCords);
            }

            Console.WriteLine(string.Join("\n", ores));
        }
    }
    class Ore
    {
        public string Type { get; set; }
        public string Cords { get; set; }
        public Ore(string type, string cords)
        {
            this.Type = type;
            this.Cords = cords;
        }
        public override string ToString()
        {
            return $"Found {this.Type} at {this.Cords}";
        }
    }
}
