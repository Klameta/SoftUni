﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
        }

        public double DefaultFuelConsumption  { get; set; }
        public virtual double FuelConsumption { get { return this.DefaultFuelConsumption; } }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual void Drive(double killometers)
        {
            Fuel -= killometers * FuelConsumption;
        }
    }
}
