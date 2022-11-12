using System;
using System.Collections.Generic;

namespace _03.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero hero= null;
                switch (type)
                {
                    case "Druid":
                        hero = new Druid(name);
                        break;
                    case "Paladin":
                        hero = new Paladin(name);
                        break;
                    case "Rogue":
                        hero = new Rogue(name);
                        break;
                    case "Warrior":
                        hero = new Warrior(name);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }

                if (hero != null) heroes.Add(hero);
                else
                {
                    i--;
                }
            }

            int bbegPower = int.Parse(Console.ReadLine());
            int partyPower = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                partyPower += hero.Power;
            }

            if (bbegPower<=partyPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
