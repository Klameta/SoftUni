using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class Cocktail : ICocktail
    {
        private string name;
        private string size;
        private double price;

        public Cocktail(string name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(string.Format(ExceptionMessages.NameNullOrWhitespace));
                name = value;
            }
        }


        public string Size
        {
            get { return size; }
            private set
            {

                size = value;
            }
        }


        public double Price
        {
            get { return price; }
            private set
            {
                if (size == "Large") price = value;
                if (size == "Middle") price = value * 2 / 3;
                if (size == "Middle") price = value / 3;
            }

        }

        public override string ToString()
        {
            return $"{name} ({size}) - {price:F2} lv";
        }

    }
}
