using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command!="end")
            {
                string result = command + " = ";
                char[] arr = command.ToCharArray();
                Array.Reverse(arr);
                result += new string(arr);
                Console.WriteLine(result);
                command = Console.ReadLine();
            }

        }
        
    }
}
