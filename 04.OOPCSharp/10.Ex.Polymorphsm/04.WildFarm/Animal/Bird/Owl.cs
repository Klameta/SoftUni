using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Feed(Food.Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                base.Feed(food);
                Weight += food.Quantity * 0.25;
            }

        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
