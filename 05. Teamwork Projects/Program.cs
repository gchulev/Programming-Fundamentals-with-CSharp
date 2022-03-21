using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] teamToCreate = Console.ReadLine().Split('-').ToArray();
                string user = teamToCreate[0];
                string teamName = teamToCreate[1];

                if (teams.Exists(q => q.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    if (teams.Exists(q => q.Creator == user))
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team()
                        {
                            Creator = user,
                            TeamName = teamName
                        };

                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {user}!");
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] cmd = command.Split("->").ToArray();
                string user = cmd[0];
                string team = cmd[1];

                if (teams.Exists(x => x.TeamName == team))
                {
                    if (teams.Exists(x => x.Members.Contains(user)) || teams.Exists(x => x.Creator == user))
                    {
                        Console.WriteLine($"Member {user} cannot join team {team}!");
                    }
                    else
                    {
                        foreach (Team tm in teams)
                        {
                            if (tm.TeamName == team)
                            {
                                tm.Members.Add(user);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }

                command = Console.ReadLine();
            }
            List<Team> teamsToDisband = new List<Team>();
            List<Team> validTeams = new List<Team>();

            teamsToDisband = teams.FindAll(x => x.Members.Count == 0);
            validTeams = teams.FindAll(x => x.Members.Count > 0);

            var teamsToDisbandOrdered = teamsToDisband.OrderBy(x => x.TeamName).ToList();
            var validTeamsOrdered = validTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName).ToList();

            foreach (Team team in validTeamsOrdered)
            {
                Console.WriteLine($"{team.TeamName}{Environment.NewLine}- {team.Creator}");
                foreach (string member in team.Members.OrderBy(q => q))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team tmToDisband in teamsToDisbandOrdered)
            {
                Console.WriteLine(string.Join($"{Environment.NewLine}", tmToDisband.TeamName));
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; } = new List<string>();
    }
}
