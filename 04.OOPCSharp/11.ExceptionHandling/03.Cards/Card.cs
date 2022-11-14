using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Cards
{
    public class Card
    {
        private string face;
        private string suit;

        private List<string> faces = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
        private List<string> suits = new List<string> { "S", "H", "D", "C" };

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"[{face}{(suit == "S" ? "\u2660": suit == "H" ? "\u2665" : suit == "D" ? "\u2666" : "\u2663")}]";
        }

        public string Face
        {
            get { return face; }
            set
            {
                if (!faces.Contains(value)) throw new ArgumentException("Invalid card!");
                face = value;
            }
        }


        public string Suit
        {
            get { return suit; }
            set
            {
                if (!suits.Contains(value)) throw new ArgumentException("Invalid card!");
                suit = value;
            }
        }

    }
}
