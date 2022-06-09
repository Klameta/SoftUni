using System;

namespace _10_PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPokePower = int.Parse(Console.ReadLine());
            int nPokePower2 = nPokePower;
            int mDistance = int.Parse(Console.ReadLine());
            int yExhaustion = int.Parse(Console.ReadLine());
            int pokeCounter = 0;

            while (mDistance <= nPokePower)
            {
                nPokePower -= mDistance;
                pokeCounter++;

                if (nPokePower == nPokePower2 - (nPokePower2 * 0.5))
                {
                    if (yExhaustion!=0 && nPokePower/yExhaustion>=1)
                    {
                        nPokePower /= (int)yExhaustion;
                    }
                }
            }
            Console.WriteLine(nPokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
