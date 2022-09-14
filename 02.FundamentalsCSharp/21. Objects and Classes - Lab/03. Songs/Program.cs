using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < counter; i++)
            {
                List<string> commandArgs = Console.ReadLine().Split('_').ToList();
                Songs song = new Songs(commandArgs[0], commandArgs[1], commandArgs[2]);
                songs.Add(song);
            }
            string com = Console.ReadLine();
            if (com != "all")
            {
                foreach (var song in songs)
                {
                    if (song.TypeList==com)
                    {
                        Console.WriteLine(song);
                    }
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song);
                }
            }

        }
    }
    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public Songs(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
