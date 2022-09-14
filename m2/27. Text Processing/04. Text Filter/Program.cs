using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filters = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var filter in filters)
            {
                string replacedAsteriks = new string('*', filter.Length);
                text =text.Replace(filter, replacedAsteriks);
            }
            Console.WriteLine(text);
        }
    }
}
