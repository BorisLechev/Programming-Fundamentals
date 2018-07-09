namespace _1.Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var items = Console.ReadLine().
                    Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string colour = items[0];
                var clothes = items[1].Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                foreach (var cloth in clothes)
                {
                    if (!wardrobe[colour].ContainsKey(cloth))
                    {
                        wardrobe[colour].Add(cloth, 0);
                    }

                    wardrobe[colour][cloth]++;
                }
            }

            var input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentClothes in wardrobe)
            {
                string currentColour = currentClothes.Key;
                var currentCloth = currentClothes.Value;

                Console.WriteLine($"{currentColour} clothes:");

                foreach (var item in currentCloth)
                {
                    string result = $"* {item.Key} - {item.Value}";

                    if (input[0] == currentColour && input[1] == item.Key)
                    {
                        result += " (found!)";
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
