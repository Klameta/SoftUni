using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heros = new List<Hero>();
            string[] command = Console.ReadLine().Split();
            string name = string.Empty;
            string spellname = string.Empty;
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Enroll":
                        name = command[1];
                        if (ContainsName(heros, name))
                        {
                            Console.WriteLine($"{name} is already enrolled.");
                        }
                        else
                        {
                            Hero hero = new Hero() { Name = name };
                            heros.Add(hero);
                        }
                        break;
                    case "Learn":
                        name = command[1];
                        spellname = command[2];
                        if (!ContainsName(heros, name))
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                        else if (ContainsSpell(heros, spellname, name))
                        {
                            Console.WriteLine($"{name} has already learnt {spellname}.");
                        }
                        else
                        {
                            foreach (var hero in heros)
                            {
                                if (hero.Name == name)
                                {
                                    hero.Powers.Add(spellname);
                                }
                            }
                        }
                        break;
                    case "Unlearn":
                        name = command[1];
                        spellname = command[2];
                        if (!ContainsName(heros, name))
                        {
                            Console.WriteLine($"{name} doesn't exist.");
                        }
                        else if (!ContainsSpell(heros, spellname, name))
                        {
                            Console.WriteLine($"{name} doesn't know {spellname}");
                        }
                        else
                        {
                            foreach (var hero in heros)
                            {
                                if (hero.Name==name)
                                {
                                    hero.Powers.Remove(spellname);
                                }
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Heroes:");
            foreach (var herp in heros)
            {
                Console.WriteLine($"== {herp.Name}: {string.Join(", ", herp.Powers)}");
                
            }
        }
        static bool ContainsName(List<Hero> heros, string name)
        {
            foreach (var hero in heros)
            {
                if (hero.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        static bool ContainsSpell(List<Hero> heros, string spellname, string name)
        {
            Hero temp = new Hero();
            foreach (var hero in heros)
            {
                if (hero.Name == name)
                {
                    temp = hero;
                }
            }
            foreach (var spell in temp.Powers)
            {
                if (spell == spellname)
                {
                    return true;
                }
            }
            return false;
        }

    }

}

class Hero
{
    public string Name { get; set; }
    public List<string> Powers = new List<string>();
}

