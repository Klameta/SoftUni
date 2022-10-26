using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _21.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whites = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] grays = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> whiteTiles = new Stack<int>();
            Queue<int> grayTiles = new Queue<int>();

            foreach (var tile in whites)
            {
                whiteTiles.Push(tile);
            }
            foreach (var tile in grays)
            {
                grayTiles.Enqueue(tile);
            }

            const int sinkArea = 40;
            const int ovenArea = 50;
            const int countertopArea = 60;
            const int wallArea = 70;

            Dictionary<string, int> decoratedAreas = new Dictionary<string, int>();



            while (grayTiles.Count != 0 && whiteTiles.Count != 0)
            {
                int currGray = grayTiles.Dequeue(); // could be peek
                int currWhite = whiteTiles.Pop();

                if (currGray == currWhite)
                {
                    int newTile = currWhite + currGray;
                    if (newTile == sinkArea)
                    {
                        if (!decoratedAreas.ContainsKey("Sink"))
                        {
                            decoratedAreas.Add("Sink", 1);
                        }
                        else decoratedAreas["Sink"]++;
                    }
                    else if (newTile == ovenArea)
                    {
                        if (!decoratedAreas.ContainsKey("Oven"))
                        {
                            decoratedAreas.Add("Oven", 1);
                        }
                        else decoratedAreas["Oven"]++;
                    }
                    else if (newTile == wallArea)
                    {
                        if (!decoratedAreas.ContainsKey("Wall"))
                        {
                            decoratedAreas.Add("Wall", 1);
                        }
                        else decoratedAreas["Wall"]++;
                    }
                    else if (newTile == countertopArea)
                    {
                        if (!decoratedAreas.ContainsKey("Countertop"))
                        {
                            decoratedAreas.Add("Countertop", 1);
                        }
                        else decoratedAreas["Countertop"]++;
                    }
                    else
                    {
                        if (!decoratedAreas.ContainsKey("Floor"))
                        {
                            decoratedAreas.Add("Floor", 1);
                        }
                        else decoratedAreas["Floor"]++;
                    };

                    //grayTiles.Pop();
                    //whiteTiles.Dequeue();
                }
                else
                {
                    currWhite /= 2;
                    whiteTiles.Push(currWhite);
                    grayTiles.Enqueue(currGray);
                }
            }

            Console.WriteLine($"White tiles left: {(whiteTiles.Count == 0 ? "none" : String.Join(", ", whiteTiles))}" +
                $"\nGrey tiles left: {(grayTiles.Count == 0 ? "none" : String.Join(", ", grayTiles))}");


           decoratedAreas = decoratedAreas.OrderByDescending(x => x.Value).ThenBy(x=>x.Key)
                .ToDictionary(x=> x.Key, x => x.Value);

            foreach (var decorated in decoratedAreas)
            {
                Console.WriteLine($"{decorated.Key}: {decorated.Value}");
            }
        }

    }
}
