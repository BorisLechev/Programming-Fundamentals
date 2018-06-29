namespace _3.TseamAccount
{
    using System;
    using System.Linq;

    public class TseamAccount
    {
        public static void Main()
        {
            var games = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Play!")
            {
                var currentCommand = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = currentCommand[0];
                string game = currentCommand[1];

                switch (command)
                {
                    case "Install":

                        if (!games.Contains(game))
                        {
                            games.Insert(games.Count, game);
                        }
                        break;

                    case "Uninstall":

                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;

                    case "Update":

                        if (games.Contains(game))
                        {
                            games.Remove(game);
                            games.Insert(games.Count, game);
                        }
                        break;

                    case "Expansion":

                        string expansion = currentCommand[2];
                        int lastIndex = games.IndexOf(game) + 1;

                        if (games.Contains(game))
                        {
                            games.Insert(lastIndex, $"{game}:{expansion}");
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", games));
        }
    }
}
