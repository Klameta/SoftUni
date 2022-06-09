using System;

namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bigValue = 0;
            int bigSnowballSnow = 0;
            int bigSnowballTime = 0;
            int bigSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int snowballValue = (int)Math.Pow((int)(snowballSnow / snowballTime), snowballQuality);

                if (snowballValue>=bigValue)
                {
                    bigValue = snowballValue;
                    bigSnowballSnow = snowballSnow;
                    bigSnowballTime = snowballTime;
                    bigSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bigSnowballSnow} : {bigSnowballTime} = {bigValue} ({bigSnowballQuality})");
        }
    }
}
