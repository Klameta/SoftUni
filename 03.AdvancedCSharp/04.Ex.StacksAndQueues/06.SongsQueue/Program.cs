﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialSongs = Console.ReadLine()
                .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            Queue<string> songs = new Queue<string>(initialSongs);

            while (songs.Count > 0)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                switch (cmdArgs[0])
                {
                    case "Play":
                        if (songs.Count > 0)
                        {
                            songs.Dequeue();
                        }
                        break;
                    case "Add":
                        string song = string.Join(" ", cmdArgs.Skip(1));

                        if (songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
