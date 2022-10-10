using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string[] cmdArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "Tournament")
            {
                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int health = int.Parse(cmdArgs[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, health);
                Trainer trainer = new Trainer(trainerName);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }

                cmdArgs = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(trainers);
        }
    }
}
