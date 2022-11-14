using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override void Feed(Food.Food food)
        {
            if (food.GetType().Name == "Vegetables" || food.GetType().Name== "Fruit")
            {
                base.Feed(food);
                Weight += food.Quantity * 0.10;
                return;
            }
            Console.WriteLine(InvalidFood(food));
        }
        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
