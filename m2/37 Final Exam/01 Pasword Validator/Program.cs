using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _01_Pasword_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int index = 0;
            char letter = ' ';
            int value = 0;
            string temp = "";
            string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "Complete")
            {
                switch (commands[0])
                {
                    case "Make":

                        if (commands[1] == "Upper")
                        {
                            index = int.Parse(commands[2]);
                            temp = MakeUpper(password, index);
                            if (temp != string.Empty)
                            {
                                password = temp;
                            }
                        }
                        else if (commands[1] == "Lower")
                        {
                            index = int.Parse(commands[2]);
                            temp = MakeLower(password, index);
                            if (temp != string.Empty)
                            {
                                password = temp;
                            }
                        }
                        break;
                    case "Insert":
                        index = int.Parse(commands[1]);
                        letter = char.Parse(commands[2].ToString());
                        temp = Insert(password, index, letter);
                        if (temp != string.Empty)
                        {
                            password = temp;
                        }

                        break;
                    case "Replace":
                        letter = char.Parse(commands[1]);
                        value = int.Parse(commands[2]);
                        temp = Replace(password, letter, value);
                        if (temp != password)
                        {
                            Console.WriteLine(temp);
                            password = temp;
                        }
                        break;
                    case "Validation":
                        ValidatePassword(password);
                        break;
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static string MakeUpper(string password, int index)
        {
            if (ValidateIndex(password, index))
            {
                char letter = password[index];
                letter = char.ToUpper(password[index]);
                char[] passChar = password.ToCharArray();
                passChar[index] = letter;
                string result = new string(passChar);
                Console.WriteLine(result);
                return result;
            }
            return "";
        }
        static string MakeLower(string password, int index)
        {
            if (ValidateIndex(password, index))
            {
                char letter = password[index];
                letter = char.ToLower(password[index]);
                char[] passChar = password.ToCharArray();
                passChar[index] = letter;
                string result = new string(passChar);
                Console.WriteLine(result);
                return result;
            }
            return "";
        }
        static string Insert(string password, int index, char letter)
        {
            if (ValidateIndex(password, index))
            {
                string result = new StringBuilder(password).Insert(index, letter).ToString();
                Console.WriteLine(result);
                return result;
            }
            return "";
        }
        static string Replace(string password, char letter, int value)
        {
            char intChar = (char)(letter + value);
            string resultSb = new StringBuilder(password).Replace(letter, intChar).ToString();

            return resultSb;
        }
        static bool ValidateIndex(string password, int index)
        {
            if (index >= password.Length || index < 0)
            {
                return false;
            }
            return true;
        }
        static void ValidatePassword(string password)
        {
            
            int lowerCounter = 0;
            int upperCounter = 0;
            int digitCounter = 0;
            bool containsBad = false;
            foreach (var letter in password)
            {
                if (Char.IsUpper(letter))
                {
                    upperCounter++;
                }

                if (char.IsLower(letter))
                {
                    lowerCounter++;
                }

                if (char.IsDigit(letter))
                {
                    digitCounter++;
                }

                if (letter != '_' && !char.IsLetterOrDigit(letter))
                {
                    containsBad = true;
                }
            }

            if (password.Length <8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }

            if (containsBad)
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
            }

            if (upperCounter < 1)
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }

            if (lowerCounter < 1)
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }

            if (digitCounter < 1)
            {
                Console.WriteLine("Password must consist at least one digit!");
            }
        }
    }
}
