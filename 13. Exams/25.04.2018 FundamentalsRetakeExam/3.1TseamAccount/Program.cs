namespace _3._1TseamAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TseamAccount
    {
        public static void Main()
        {
            var listOfGames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Play!")
            {
                var currentInput = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string game = currentInput[1];

                switch (currentInput[0])
                {
                    case "Install":
                        Install(listOfGames, game);
                        break;

                    case "Uninstall":
                        Uninstall(listOfGames, game);
                        break;

                    case "Update":
                        Update(listOfGames, game);
                        break;

                    case "Expansion":
                        Expansion(listOfGames, currentInput);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", listOfGames));
        }

        public static void Expansion(List<string> listOfGames, List<string> currentInput)
        {
            string expansionGameFirstPart = currentInput[1];
            string expansionGameSecondPart = currentInput[2];

            if (listOfGames.Contains(expansionGameFirstPart))
            {
                var indexOfFirstGame = listOfGames.IndexOf(expansionGameFirstPart) + 1;

                listOfGames.Insert(indexOfFirstGame, $"{expansionGameFirstPart}:{expansionGameSecondPart}");
            }
        }

        public static void Update(List<string> listOfGames, string game)
        {
            if (listOfGames.Contains(game))
            {
                listOfGames.Remove(game);
                listOfGames.Insert(listOfGames.Count, game);
            }
        }

        public static void Uninstall(List<string> listOfGames, string game)
        {
            if (listOfGames.Contains(game))
            {
                listOfGames.Remove(game);
            }
        }

        public static void Install(List<string> listOfGames, string game)
        {
            if (!listOfGames.Contains(game))
            {
                listOfGames.Insert(listOfGames.Count, game);
            }
        }
    }
}

