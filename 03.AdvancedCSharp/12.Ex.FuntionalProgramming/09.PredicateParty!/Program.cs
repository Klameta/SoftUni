using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> startingWithString = (name, givenString) => name.StartsWith(givenString);
            Func<string, string, bool> endingWithGivenString = (name, givenString) => name.EndsWith(givenString);
            Func<string, int, bool> sameLenght = (name, lenght) => name.Length == lenght;


            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "Party!")
            {
                List<string> temp = new List<string>();
                switch (cmdArgs[0])
                {
                    case "Double":
                        if (cmdArgs[1] == "Length")
                        {
                            int lenght = int.Parse(cmdArgs[2]);
                            temp = names.Where(x => sameLenght(x, lenght)).ToList();
                            names = Adding(names, temp);
                        }
                        else if (cmdArgs[1] == "StartsWith")
                        {
                            temp = names.Where(x => startingWithString(x, cmdArgs[2])).ToList();
                            names = Adding(names, temp);

                        }
                        else if (cmdArgs[1] == "EndsWith")
                        {
                            temp = names.Where(x => endingWithGivenString(x, cmdArgs[2])).ToList();
                            names = Adding(names, temp);
                        }
                        break;
                    case "Remove":
                        if (cmdArgs[1] == "Lenght")
                        {
                            int lenght = int.Parse(cmdArgs[2]);
                            temp = names.Where(x => sameLenght(x, lenght)).ToList();
                            Removing(names, temp);
                        }
                        else if (cmdArgs[1] == "StartsWith")
                        {
                            temp = names.Where(x => startingWithString(x, cmdArgs[2])).ToList();
                            Removing(names, temp);
                        }
                        else if (cmdArgs[1] == "EndsWith")
                        {
                            temp = names.Where(x => endingWithGivenString(x, cmdArgs[2])).ToList();
                            Removing(names, temp);
                        }
                        break;
                }
                cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static List<string> Adding(List<string> names, List<string> temp)
        {
            temp.AddRange(names);
            names = temp;
            return names;
        }

        public static void Removing(List<string> names, List<string> temp)
        {
            foreach (var str in temp)
            {
                names.Remove(str);
            }
        }
    }
}
