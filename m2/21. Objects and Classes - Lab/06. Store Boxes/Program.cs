using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{this.Name} – {this.Price:F2}";
        }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
        public Box(string serialNumber, Item item, int quantity, double price)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = quantity;
            this.Price = price;
        }

    }
}
