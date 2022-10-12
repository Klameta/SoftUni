﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            Name = name;
            badges = 0;
            pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        Action<Pokemon> removingHealth = pokemon => pokemon.Health -= 10;
        Predicate<Pokemon> IsDead = pokemon => pokemon.Health >= 0;

        public void Tournament(string type)
        {
            if (pokemons.Any(x => x.Element == type))
            {
                badges++;
            }
            else
            {
                pokemons.ForEach(x => removingHealth(x));
                if (pokemons.Any(x => x.Health <= 0))
                {
                    List<Pokemon> removed = Pokemons
                            .Where(x => x.Health <= 0)
                            .ToList();
                    foreach (var pokem in removed.Where(pokem => Pokemons.Contains(pokem)))
                    {
                        Pokemons.Remove(pokem);
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
