using System;

namespace _09_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double lightsaberP = double.Parse(Console.ReadLine()); ;
            double robeP = double.Parse(Console.ReadLine());
            double beltP = double.Parse(Console.ReadLine());

            double price = 0.0;
            double freeB = Math.Floor((double)students / 6);
            var saberBS = Math.Ceiling(students + students * 0.1);


            price = lightsaberP * saberBS + robeP * (students) + beltP * (students - freeB);

            if (money>=price)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {price-money:F2}lv more.");
            }
        }
    }
}
