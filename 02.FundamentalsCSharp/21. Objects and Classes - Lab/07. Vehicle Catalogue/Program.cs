using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split("/");
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            Catalog catalog = new Catalog(cars, trucks);
            while (commandArgs[0] != "end")
            {
                string type = commandArgs[0];
                if (type == "Car")
                {
                    Car car = new Car(commandArgs[1], commandArgs[2], commandArgs[3]);
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(commandArgs[1], commandArgs[2], commandArgs[3]);
                    trucks.Add(truck);
                }
                commandArgs = Console.ReadLine().Split("/");
            }
            if (cars.Count > 0)
            {
                cars = cars.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }

            if (trucks.Count > 0)
            {
                trucks = trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var truck in trucks)
                {
                    Console.WriteLine(truck);
                }
            }


        }
    }
    public class Truck
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Weight { get; set; }

        public Truck(string brand, string model, string weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.Weight}kg";
        }

    }
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Power { get; set; }

        public Car(string brand, string model, string Power)
        {
            this.Brand = brand;
            this.Model = model;
            this.Power = Power;
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.Power}hp";
        }

    }
    class Catalog
    {
        public List<Car> CatCar { get; set; }

        public List<Truck> CatTruck { get; set; }
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.CatCar = cars;
            this.CatTruck = trucks;
        }
    }
}
