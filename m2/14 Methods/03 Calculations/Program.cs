using System;

namespace _03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            
            switch (command)
            {
                case "add":
                    Addition(firstNum, secondNum);
                    break;
                case "multiply":
                    Multiplication(firstNum, secondNum);
                    break;
                case "subtract":
                    Substraction(firstNum, secondNum);
                    break;
                case "divide":
                    Division(firstNum, secondNum);
                    break;
            }
        }
        static void Addition(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum+secondNum);
        }
        static void Substraction(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum-secondNum);
        }
        static void Multiplication(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum*secondNum);
        }
        static void Division(int firstNum, int secondNum)
        {
            Console.WriteLine((int)(firstNum/secondNum));
        }
    }
}
