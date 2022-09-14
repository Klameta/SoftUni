using System;

namespace _11_RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Length: ");
            decimal lenght = decimal.Parse(Console.ReadLine());

            Console.Write("Width: ");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.Write("Height: ");
            decimal height = decimal.Parse(Console.ReadLine());

            decimal volume = ((lenght * width * height)/3);

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
