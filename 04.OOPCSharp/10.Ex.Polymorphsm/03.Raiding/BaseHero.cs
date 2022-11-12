using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding
{
    public class BaseHero
    {
        public BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public virtual string CastAbility()
        {
            return $"{GetType().Name} - {Name} {(GetType().Name == "Druid" || GetType().Name == "Paladin" ? "healed" : "hit")} for {Power}{(GetType().Name == "Druid" || GetType().Name == "Paladin" ? "" : " damage")}";
        }

        public string Name { get; private set; }
        public int Power { get; private set; }

    }
}
