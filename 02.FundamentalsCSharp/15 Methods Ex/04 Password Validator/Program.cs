using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (!LongEnough(password))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }
            if (!ContainsOnlyLettersAndNums(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!HasTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (LongEnough(password)&&ContainsOnlyLettersAndNums(password)&&HasTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool LongEnough(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
        static bool ContainsOnlyLettersAndNums(string pasword)
        {
            string bigPassword = pasword.ToUpper();
            foreach (var letter in bigPassword)
            {

                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HasTwoDigits(string pasword)
        {
            int counter = 0;
            foreach (var letter in pasword)
            {
                if (letter >= '0' && letter <= '9')
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
