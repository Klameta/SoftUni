using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                int index = word.IndexOf(filter);
                if (index>=0)
                {
                    word = word.Remove(index, filter.Length);
                }
            }
            Console.WriteLine(word);
        }
    }
}
