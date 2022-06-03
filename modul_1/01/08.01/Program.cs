using System;

namespace _08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int eHour = int.Parse(Console.ReadLine());
            int eMin = int.Parse(Console.ReadLine());
            int aHour = int.Parse(Console.ReadLine());
            int aMin = int.Parse(Console.ReadLine());

            eMin = eMin + eHour * 60;
            aMin = aMin + aHour * 60;

            if (eMin<aMin)
            {
                Console.WriteLine($"Late");
                if (aHour-eMin>=60)
                {

                }
            }
            else if (eMin-aMin<=30)
            {
                Console.WriteLine($"On time");
            }
            else
            {
                Console.WriteLine($"");
            }
        }
    }
}
