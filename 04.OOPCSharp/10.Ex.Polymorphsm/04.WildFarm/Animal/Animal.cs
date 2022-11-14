using System;
using System.Collections.Generic;
using System.Text;
using _04.WildFarm.Food;

namespace _04.WildFarm.Animal
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public virtual void Feed(Food.Food food)
        {
            FoodEaten += food.Quantity;
        }

        protected string InvalidFood(Food.Food food)
        {
            return $"{this.GetType().Name} does not eat {food.GetType().Name}!";

        }
        public virtual string ProduceSound()
        {
            return string.Empty;
        }

    }
}
