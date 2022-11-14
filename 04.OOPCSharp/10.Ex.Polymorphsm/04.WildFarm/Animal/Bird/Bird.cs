using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Bird
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }

        public double WingSize { get; set; }
    }
}
