using System;
using System.Linq;
using System.Collections.Generic;
namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();
            string[] commandArgs = Console.ReadLine().Split();
            while (commandArgs[0] != "End")
            {
                //Until you receive the "End" command, you will be receiving lines of input in the following format:
                //"{typeOfVehicle} {model} {color} {horsepower}"
                Vehicle vehicle = new Vehicle(commandArgs[0], commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));
                vehicles.Add(vehicle);
                commandArgs = Console.ReadLine().Split();
            }
            string model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                //When you receive the "End" command, you will start receiving information about some vehicles
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model==model)
                    {
                        Console.WriteLine(vehicle);
                        break;
                    }
                }
                model = Console.ReadLine();
            }
            //When you receive the "Close the Catalogue" command
            //print out the average horsepower of the cars and the average horsepower of
            //the trucks in the format:
            //"{typeOfVehicles} have average horsepower of {averageHorsepower}."
            OutPut("car", Avr(vehicles, "car"));
            OutPut("truck", Avr(vehicles, "truck"));
        }
        static void OutPut(string type, double avr)
        {
            if (type=="car")
            {
                Console.WriteLine($"Cars have average horsepower of: {avr:F2}.");
                return;
            }
            Console.WriteLine($"Trucks have average horsepower of: {avr:F2}.");
        }
        static double Avr(List<Vehicle> vehicles, string type)
        {
            int counter = 0;
            int sum = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type==type)
                {
                    counter++;
                    sum += vehicle.HoursePower;
                }
            }
            return (double)sum / counter;
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HoursePower { get; set; }

        public Vehicle(string type, string model, string color, int hoursepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HoursePower = hoursepower;
        }
        public override string ToString()
        {
            return $"Type: {(char.ToUpper(this.Type[0]) + this.Type.Substring(1))}\nModel: {this.Model}\nColor: {this.Color}\nHorsepower: {this.HoursePower}";
        }
    }
}

