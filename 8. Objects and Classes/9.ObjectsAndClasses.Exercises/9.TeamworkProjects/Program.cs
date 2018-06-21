namespace _9.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamworkProjects
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < number; i++)
            {
                var inputForNewTeam = Console.ReadLine().Split('-').ToList();
                var membersList = new List<string>();
                Team team = new Team();

                team.Creator = inputForNewTeam[0];
                team.TeamName = inputForNewTeam[1];
                team.Members = membersList;

                if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!teams.Select(x => x.Creator).Contains(team.Creator))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                    }

                    else
                    {
                        Console.WriteLine($"{team.Creator} cannot create another team!");
                    }
                }

                else
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                }
            }

            var teamRegistration = Console.ReadLine()
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (teamRegistration[0] != "end of assignment")
            {
                var newMember = teamRegistration[0];
                var team = teamRegistration[1];

                if (!teams.Select(x => x.TeamName).Contains(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }

                else if (teams.Select(x => x.Members).Any(x => x.Contains(newMember) ||
                teams.Select(y => y.Creator).Contains(newMember)))
                {
                    Console.WriteLine($"Member {newMember} cannot join team {team}!");
                }

                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.TeamName == team);
                    teams[teamToJoinIndex].Members.Add(newMember);
                }

                teamRegistration = Console.ReadLine()
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var teamToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var fullTeams = teams.OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName).Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamToDisband)
            {
                Console.WriteLine($"{item.TeamName}");
            }
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }
    }
}
