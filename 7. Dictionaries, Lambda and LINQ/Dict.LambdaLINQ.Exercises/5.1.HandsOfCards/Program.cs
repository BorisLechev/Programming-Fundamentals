namespace _5._1.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var playerCards = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "JOKER")
            {
                var currentInput = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string playerName = currentInput[0];
                var cards = currentInput[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!playerCards.ContainsKey(playerName))
                {
                    playerCards.Add(playerName, new List<string>());
                }

                playerCards[playerName].AddRange(cards);
            }

            foreach (var item in playerCards)
            {
                string playerName = item.Key;
                var cards = playerCards[item.Key].Distinct().ToList();

                int sum = CalculateTheValue(playerName, cards);

                Console.WriteLine($"{playerName}: {sum}");
            }
        }

        public static int CalculateTheValue(string playerName, List<string> cards)
        {
            int sum = 0;

            foreach (var card in cards)
            {
                string powerAsString = string.Empty;

                if (card.Count() == 3)
                {
                    powerAsString = card[0].ToString() + card[1].ToString();
                }

                else
                {
                    powerAsString = card[0].ToString();
                }

                string typeAsString = card[card.Count() - 1].ToString();
                int power = GetPowerAsInt(powerAsString);
                int type = GetTypeAsInt(typeAsString);
                sum += power * type;
            }

            return sum;
        }

        public static int GetPowerAsInt(string powerAsString)
        {
            int power = 0;

            switch (powerAsString)
            {
                case "2":
                    power = 2;
                    break;

                case "3":
                    power = 3;
                    break;

                case "4":
                    power = 4;
                    break;

                case "5":
                    power = 5;
                    break;

                case "6":
                    power = 6;
                    break;

                case "7":
                    power = 7;
                    break;

                case "8":
                    power = 8;
                    break;

                case "9":
                    power = 9;
                    break;

                case "10":
                    power = 10;
                    break;

                case "J":
                    power = 11;
                    break;

                case "Q":
                    power = 12;
                    break;

                case "K":
                    power = 13;
                    break;

                case "A":
                    power = 14;
                    break;
            }

            return power;
        }

        public static int GetTypeAsInt(string typeAsString)
        {
            int type = 0;

            switch (typeAsString)
            {
                case "S":
                    type = 4;
                    break;

                case "H":
                    type = 3;
                    break;

                case "D":
                    type = 2;
                    break;

                case "C":
                    type = 1;
                    break;
            }

            return type;
        }
    }
}

