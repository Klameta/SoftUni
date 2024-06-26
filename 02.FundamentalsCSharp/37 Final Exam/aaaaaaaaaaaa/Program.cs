﻿using System;
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
            string[] commands = Console.ReadLine().Split();
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
                        else
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
                commands = Console.ReadLine().Split();
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
                char[] passChar = password.ToCharArray();
                passChar[index] = letter;
                string result = new string(passChar);

                
                Console.WriteLine(result);
                return result;
            }
            return "";
        }
        static string Replace(string password, char letter, int value)
        {
            string result = "";
            char intChar = (char)(letter + value);
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == letter)
                {
                    result += intChar;
                }
                else
                {
                    result += password[i];
                }
            }
            return result;
        }
        static bool ValidateIndex(string password, int index)
        {
            if (index >= password.Length || index < 0)
            {
                return false;
            }
            return true;
        }
        static bool ValidatePassword(string password)
        {
            if (password.Length <= 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
                return false;
            }
            int lowerCounter = 0;
            int upperCounter = 0;
            int digitCounter = 0;

            foreach (var letter in password)
            {
                if (Char.IsUpper(letter))
                {
                    upperCounter++;
                }
                else if (char.IsLower(letter))
                {
                    lowerCounter++;
                }
                else if (char.IsDigit(letter))
                {
                    digitCounter++;
                }
                else if (letter != '_')
                {
                    Console.WriteLine("Password must consist only of letters, digits and _!");
                    return false;
                }
            }
            if (upperCounter < 1)
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
                return false;
            }
            else if (lowerCounter < 1)
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
                return false;
            }
            else if (digitCounter < 1)
            {
                Console.WriteLine("Password must consist at least one digit!");
                return false;
            }
            return true;
        }
    }
}
