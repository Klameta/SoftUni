using System;

namespace _10_Rage
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetP = double.Parse(Console.ReadLine());
            double mouseP = double.Parse(Console.ReadLine());
            double keyboardP = double.Parse(Console.ReadLine());
            double displayP = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int keyboardCount2 = 0;
            int displayCount = 0;

            double price = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 6 == 0)
                {
                    keyboardCount++;
                    headsetCount++;
                    mouseCount++;
                }
                else if (i % 2 == 0)
                {
                    headsetCount++;
                }
                else if (i % 3 == 0)
                {
                    mouseCount++;
                }
                
                if (keyboardCount % 2 == 0 && keyboardCount > 1)
                {
                    displayCount++;
                    keyboardCount2 += keyboardCount;
                    keyboardCount = 0;
                }
            }
            keyboardCount2 += keyboardCount;
            price = (headsetCount * headsetP) + (mouseCount * mouseP) + (keyboardCount2 * keyboardP) + (displayCount * displayP);

            Console.WriteLine($"Rage expenses: {price:F2} lv.");
        }
    }
}
