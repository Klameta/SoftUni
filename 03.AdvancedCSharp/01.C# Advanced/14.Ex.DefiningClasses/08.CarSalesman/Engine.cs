using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public override string ToString()
        {
            return $"  {this.Model}:" +
                $"\n    Power: {this.Power}" +
                $"\n    Displacement: {(this.Displacement.ToString() == "0" ? "n/a" : this.Displacement.ToString())}" +
                $"\n    Efficiency: {(this.Efficiency is null ? "n/a" : this.Efficiency)}";
        }
    }
}
