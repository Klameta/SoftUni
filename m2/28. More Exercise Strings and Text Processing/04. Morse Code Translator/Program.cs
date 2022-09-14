using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseAplhabet = new Dictionary<string, char>();
            {
                morseAplhabet.Add(".-", 'A');
                morseAplhabet.Add("-...", 'B');
                morseAplhabet.Add("-.-.", 'C');
                morseAplhabet.Add("-..", 'D');
                morseAplhabet.Add(".", 'E');
                morseAplhabet.Add("..-.", 'F');
                morseAplhabet.Add("--.", 'G');
                morseAplhabet.Add("....", 'H');
                morseAplhabet.Add("..", 'I');
                morseAplhabet.Add(".---", 'J');
                morseAplhabet.Add("-.-", 'K');
                morseAplhabet.Add(".-..", 'L');
                morseAplhabet.Add("--", 'M');
                morseAplhabet.Add("-.", 'N');
                morseAplhabet.Add("---", 'O');
                morseAplhabet.Add(".--.", 'P');
                morseAplhabet.Add("--.-", 'Q');
                morseAplhabet.Add(".-.", 'R');
                morseAplhabet.Add("...", 'S');
                morseAplhabet.Add("-", 'T');
                morseAplhabet.Add("..-", 'U');
                morseAplhabet.Add("...-", 'V');
                morseAplhabet.Add(".--", 'W');
                morseAplhabet.Add("-..-", 'X');
                morseAplhabet.Add("-.--", 'Y');
                morseAplhabet.Add("--..", 'Z');
            }
            string[] morseBig = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder english = new StringBuilder();
            foreach (var morsePart in morseBig)
            {
                string[] morseSmall = morsePart.Split();
                foreach (var morseLetter in morseSmall)
                {
                    if (morseAplhabet.ContainsKey(morseLetter))
                    {
                        english.Append(morseAplhabet[morseLetter]);
                    }
                }
                english.Append(" ");
            }
            Console.WriteLine(english);
        }

    }
}
