using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int nAdults = 0;
            int nKids = 0;
            int mToys = 0;
            int mSweaters = 0;
            while (input != "Christmas")
            {
                int ages = int.Parse(input);

                if (ages<=16)
                {
                    nKids++;
                }
                else
                {
                    nAdults++;
                }
                input = Console.ReadLine();

            }
            mToys = 5 * nKids;
            mSweaters = 15 * nAdults;

            Console.WriteLine($"Number of adults: {nAdults}");
            Console.WriteLine($"Number of kids: {nKids}");
            Console.WriteLine($"Money for toys: {mToys}");
            Console.WriteLine($"Money for sweaters: {mSweaters}");

        }
    }
}
