using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal.Mammal.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override void Feed(Food.Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                base.Feed(food);
                Weight += food.Quantity * 1;
                return;
            }
            Console.WriteLine(InvalidFood(food));
        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
