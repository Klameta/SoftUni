using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicle
{
    public abstract class Vehicle
    {
        private double fuel;
        private double consumption;

        public double Fuel
        {
            get { return fuel; }
           set { fuel = value; }
        }
        public double Consumption
        {
            get { return consumption; }
           set { consumption = value; }
        }

        public Vehicle(double fuel, double consumption)
        {
            Fuel = fuel;
            Consumption = consumption;
        }
        public virtual void Drive(double kmToBeDriven)
        {
        }

        public virtual void Refuel(double liters)
        {

        }
        public override string ToString()
        {
            return $"{GetType().Name}: {this.Fuel:F2}";
        }
    }
}
