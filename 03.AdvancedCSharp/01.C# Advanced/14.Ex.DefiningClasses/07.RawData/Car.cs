using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
		private string model;
		private Engine engineOfCar;
		private Cargo cargoOfCar;
        private Tire[] tires;
		public Car(string model, Engine engineOfCar, Cargo cargoOfCar, Tire[] tires)
		{
			Model = model;
			EngineOfCar = engineOfCar;
			CargoOfCar = cargoOfCar;
			Tires = new Tire[4];
			Tires = tires;
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

		public Cargo CargoOfCar
		{
			get { return cargoOfCar; }
			set { cargoOfCar = value; }
		}
        public Tire[] Tires { get => tires; set => tires = value; }

		public override string ToString()
		{
			return $"{this.Model}";
		}

	}
}
