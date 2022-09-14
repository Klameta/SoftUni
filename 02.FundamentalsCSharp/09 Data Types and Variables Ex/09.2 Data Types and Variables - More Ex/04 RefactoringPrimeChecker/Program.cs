using System;

namespace _04_RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandargs = int.Parse(Console.ReadLine());

            for (int i = 2; i <= commandargs; i++)
            {
                bool checker = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        checker = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {checker.ToString().ToLower()}");
            }
        }
    }
}
