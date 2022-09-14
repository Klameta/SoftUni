using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nteams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < Nteams; i++)
            {
                string[] commandArgs = Console.ReadLine().Split("-");
                bool contains = false;
                foreach (var tm in teams)
                {
                    if (tm.Name == commandArgs[1])
                    {
                        Console.WriteLine($"Team {commandArgs[1]} was already created!");
                        contains = true;
                        break;
                    }
                    else if (tm.Creator == commandArgs[0])
                    {
                        Console.WriteLine($"{commandArgs} cannot create another team!");
                        contains = true;
                        break;
                    }
                }

                if (!contains)
                {
                    Team team = new Team(commandArgs[1], commandArgs[0]);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                    teams.Add(team);
                }
                commandArgs = Console.ReadLine().Split("-");

            }
            string[] addingMembers = Console.ReadLine().Split("->");
            while (addingMembers[0]!= "end of assignment")
            {
                bool contains = false;

                if (!contains)
                {
                    
                }
                addingMembers = Console.ReadLine().Split("->");
            }
        }

    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
        }
        public override string ToString()
        {
            string output = $"{this.Name}\n- {this.Creator}";
            foreach (var member in this.Members)
            {
                output += $"\n-- {member}";
            }
                
            return output;
        }
    }
}
