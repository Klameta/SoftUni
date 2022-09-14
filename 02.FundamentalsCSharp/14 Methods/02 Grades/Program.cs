using System;

namespace _02_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine(Grading(grade));
        }
        static string Grading(double grade)
        {
            if (grade<2.99)
            {
                return "Fail";
            }
            else if (grade <3.49)
            {
                return "Poor";
            }
            else if (grade < 4.49)
            {
                return "Good";
            }
            else if (grade<5.49)
            {
                return "Very good";
            }
            else
            {
                return "Excellent";
            }
        }
    }
}
