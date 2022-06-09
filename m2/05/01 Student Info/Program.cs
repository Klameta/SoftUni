using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Student_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var avrGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avrGrade:F2}");
        }
    }
}
