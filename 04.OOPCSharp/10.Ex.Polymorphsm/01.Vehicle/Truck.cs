using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicle
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override void Refuel(double liters)
        {
            Fuel += liters * 0.95;
        }
        public override void Drive(double kmToBeDriven)
        {
            var kmNeeded = kmToBeDriven * (1.6 + Consumption);
            if (kmNeeded <= this.Fuel)
            {
                this.Fuel -= kmNeeded;
                Console.WriteLine($"{this.GetType().Name} travelled {kmToBeDriven} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }
    }
}
