using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(", ");
                switch (commandArgs[0])
                {
                    case "Add":
                        string cardName = commandArgs[1];
                        Add(cards, cardName);
                        break;
                    case "Remove":
                        cardName = commandArgs[1];
                        Remove(cards, cardName);
                        break;
                    case "Remove At":
                        int index = int.Parse(commandArgs[1]);
                        RemoveAt(cards, index);
                        break;
                    case "Insert":
                        index = int.Parse(commandArgs[1]);
                        cardName = commandArgs[2];
                        Insert(cards, cardName, index);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", cards));
        }
        static void Add(List<string> cards, string cardName)
        {
            if (cards.Contains(cardName))
            {
                Console.WriteLine("Card is already in the deck");
                return;
            }
            cards.Add(cardName);
            Success(true);
        }
        static void Remove(List<string> cards, string cardName)
        {
            if (cards.Contains(cardName))
            {
                cards.Remove(cardName);
                Success(false);
                return;
            }
            Console.WriteLine($"Card not found");
        }
        static void RemoveAt(List<string> cards, int index)
        {
            if (index < cards.Count)
            {
                cards.RemoveAt(index);
                Success(false);
                return;
            }
            Console.WriteLine("Index out of range");
        }
        static void Insert(List<string> cards, string cardName, int index)
        {
            if (cards.Count <= index || index < 0)
            {
                Console.WriteLine("Index out of range");
                return;
            }

            if (cards.Contains(cardName))
            {
                Console.WriteLine("Card is already added");
                return;
            }
            cards.Insert(index, cardName);
            Success(true);
        }
        static void Success(bool foo)
        {
            if (foo)
            {
                Console.WriteLine("Card successfully added");
                return;
            }
            else
            {
                Console.WriteLine("Card successfully removed");
                return;
            }
        }
    }
}
