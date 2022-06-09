using System;

namespace _09_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string compare1 = Console.ReadLine();
            string compare2 = Console.ReadLine();

            if (type=="char")
            {
                char letter1 = char.Parse(compare1);
                char letter2 = char.Parse(compare2);
                Console.WriteLine(GetMax(letter1,letter2));
            }
            else if(type == "int")
            {
                int num1 = int.Parse(compare1);
                int num2 = int.Parse(compare2);
                Console.WriteLine((GetMax(num1,num2)));
            }
            else
            {
                Console.WriteLine((GetMax(compare1,compare2)));
            }
        }
        static char GetMax(char compare1, char compare2)
        {
            if ((int)compare1>compare2)
            {
                return compare1;
            }
           
                return compare2;
            
        }
        static int GetMax(int compare1, int compare2)
        {
            if (compare1 > compare2)
            {
                return compare1;
            }
                return compare2;
            
        }
        static string GetMax(string compare1, string compare2)
        {
            int result = compare1.CompareTo(compare2);
            if (result>0)
            {
                return compare1;
            }
            return compare2;
        }
    }
}
