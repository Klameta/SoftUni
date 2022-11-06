using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public void Purchase(Product product)
        {
            if (money >= product.Cost)
            {
                money -= product.Cost;
                bag.Add(product);

                Console.WriteLine($"{Name} bought {product.Name}");

                return;
            }

            Console.WriteLine($"{Name} can't afford {product.Name}");
        }

        public override string ToString()
        {
            if (bag.Count > 0) return $"{Name} - {string.Join(", ", bag.Select(x => x.Name))}";

            return $"{Name} - Nothing bought";
        }

        public IReadOnlyCollection<Product> Bag { get { return bag.AsReadOnly(); } }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");

                name = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0) throw new ArgumentException("Money cannot be negative");
                money = value;
            }
        }
    }

}
