using System;
namespace _05_DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int nLetters = int.Parse(Console.ReadLine());
            string decrypted = "";
            for (int i = 0; i < nLetters; i++)
            {
                char currentletter = char.Parse(Console.ReadLine());
                char decryptedLetter = (char)((int)currentletter + key);
                decrypted += decryptedLetter;
            }
            Console.WriteLine(decrypted);
        }
    }
}
