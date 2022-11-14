using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Mammal.Feline
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override void Feed(Food.Food food)
        {
            if (food.GetType().Name == "Meat" || food.GetType().Name == "Vegetable")
            {
                base.Feed(food);
                Weight += food.Quantity * 0.30;
                return;
            }
            Console.WriteLine(InvalidFood(food));
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
