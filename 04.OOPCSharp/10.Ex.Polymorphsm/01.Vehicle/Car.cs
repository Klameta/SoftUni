using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicle
{
    public class Car : Vehicle
    {
        public Car(double fuel, double consumption) : base(fuel, consumption)
        {
        }

        public override void Refuel(double liters)
        {
            this.Fuel += liters;
        }
        public override void Drive(double kmToBeDriven)
        {
            var kmNeeded = (Consumption + 0.9) * kmToBeDriven;

            if (kmNeeded <= this.Fuel)
            {
                this.Fuel -= kmNeeded;
                Console.WriteLine($"{GetType().Name} travelled {kmToBeDriven} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }
    }
}
