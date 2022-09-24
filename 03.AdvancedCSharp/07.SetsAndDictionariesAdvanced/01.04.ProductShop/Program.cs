using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> stores = new SortedDictionary<string, Dictionary<string, double>>();
            string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (cmdArgs[0]!= "Revision")
            {
                if (!stores.ContainsKey(cmdArgs[0]))
                {
                    stores.Add(cmdArgs[0], new Dictionary<string, double>());
                    stores[cmdArgs[0]].Add(cmdArgs[1], double.Parse(cmdArgs[2]));
                }
                else
                {
                    stores[cmdArgs[0]].Add(cmdArgs[1], double.Parse(cmdArgs[2]));
                }

                cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
