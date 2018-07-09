namespace _5.Commits
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Commits
    {
        public static void Main()
        {
            var database = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();
            string pattern =
                @"https:\/\/github.com\/([A-Za-z\d-]+)\/([[A-Za-z-_]+)\/commit\/([\da-f]{40}),([^\n]+),([\d]+),([\d]+)";

            string input = Console.ReadLine();

            while (input != "git push")
            {
                var userAndCommit = Regex.Match(input, pattern);

                if (userAndCommit.Success)
                {
                    string username = userAndCommit.Groups[1].Value;
                    string repositoryName = userAndCommit.Groups[2].Value;
                    string commitHash = userAndCommit.Groups[3].Value;
                    string message = userAndCommit.Groups[4].Value;
                    decimal additions = decimal.Parse(userAndCommit.Groups[5].Value);
                    decimal deletions = decimal.Parse(userAndCommit.Groups[6].Value);

                    var currentCommit = new Commit(commitHash, message, additions, deletions);

                    if (!database.ContainsKey(username))
                    {
                        database[username] = new SortedDictionary<string, List<Commit>>(); ///////
                    }

                    if (!database[username].ContainsKey(repositoryName))
                    {
                        database[username][repositoryName] = new List<Commit>();
                    }

                    database[username][repositoryName].Add(currentCommit);
                }

                input = Console.ReadLine();
            }

            decimal aditionSum = 0;
            decimal deletionsSum = 0;

            foreach (var user in database)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var repo in database[user.Key])
                {
                    Console.WriteLine($"  {repo.Key}:");

                    foreach (var commit in repo.Value)
                    {
                        aditionSum += commit.Additions;
                        deletionsSum += commit.Deletions;

                        Console.WriteLine($"    commit {commit.Hash}:" +
                            $" {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }

                    Console.WriteLine($"    Total: {aditionSum} additions, {deletionsSum} deletions");

                    aditionSum = 0;
                    deletionsSum = 0;
                }
            }
        }
    }

    public class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public decimal Additions { get; set; }
        public decimal Deletions { get; set; }

        public Commit(string commitHash, string message, decimal additions, decimal deletions)
        {
            Hash = commitHash;
            this.Message = message;
            this.Additions = additions;
            this.Deletions = deletions;
        }
    }
}
