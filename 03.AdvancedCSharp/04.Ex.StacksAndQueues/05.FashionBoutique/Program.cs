using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>();

            foreach (var num in inputNums)
            {
                clothes.Push(num);
            }

            int capacity = int.Parse(Console.ReadLine());
            int sumOfClothes = 0;
            int racks = 1;
            bool emptyStack = false;

            if (clothes.Count <= 0)
            {
                emptyStack = true;
            }

            while (!emptyStack)
            {
                    int curClothing = clothes.Peek();

                while (sumOfClothes + curClothing <= capacity && !emptyStack)
                {
                    curClothing = clothes.Pop();
                    sumOfClothes += curClothing;

                    if (clothes.Count == 0)
                    {
                        emptyStack = true;
                    }
                    else
                    {
                        curClothing = clothes.Peek();
                    }
                }
                racks++;
                sumOfClothes = 0;
                if (clothes.Count == 0)
                {
                    emptyStack = true;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
