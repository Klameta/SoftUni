using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Mammal
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        public string LivingRegion { get; set; }
    }
}
