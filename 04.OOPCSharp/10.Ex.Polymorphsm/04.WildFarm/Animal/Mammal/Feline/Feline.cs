using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
        public string Breed { get; set; }
    }
}
