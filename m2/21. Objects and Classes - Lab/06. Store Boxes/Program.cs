using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();
            while (commandArgs[0]!="end")
            {
                int quant = int.Parse(commandArgs[2]);
                double price = double.Parse(commandArgs[3]);
                Item item = new Item(commandArgs[1], price);
                Box box = new Box(commandArgs[0], item, quant, quant*price );
                boxes.Add(box);
                commandArgs = Console.ReadLine().Split();
            }
            boxes =boxes.OrderByDescending(x => x.Price).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
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
            return $"{this.Name} - ${this.Price:F2}";
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
        public override string ToString()
        {
            return $"{this.SerialNumber}\n-- {this.Item}: {this.ItemQuantity}\n-- ${this.Price:F2}";
        }

    }
}
