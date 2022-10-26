using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engineOfCar;
        private int weight;
        private string color;

        public Car(string model, Engine engineOfCar)
        {
            Model = model;
            EngineOfCar = engineOfCar;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine EngineOfCar
        {
            get { return engineOfCar; }
            set { engineOfCar = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return $"{this.Model}:" +
                $"\n{this.EngineOfCar}" +
                $"\n  Weight: {(this.Weight.ToString() == "0" ? "n/a" : this.Weight.ToString())}" +
                $"\n  Color: {(this.Color is null ? "n/a" : this.Color)}";
        }
    }
}
