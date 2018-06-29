namespace _3.StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StarEnigma
    {
        public static void Main()
        {
            var attackList = new List<string>();
            var destroyList = new List<string>();

            int numberOfEncryptedMessages = int.Parse(Console.ReadLine());

            string keyPattern = @"[starSTAR]";
            var keyRegex = new Regex(keyPattern);

            string messagePattern = @"@([a-zA-Z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([AD])![^@\-!:>]*->(\d+)";
            var messageRegex = new Regex(messagePattern);

            for (int i = 0; i < numberOfEncryptedMessages; i++)
            {
                string input = Console.ReadLine();

                StringBuilder stringBuilder = new StringBuilder();

                int keyMatch = keyRegex.Matches(input).Count;

                for (int j = 0; j < input.Length; j++)
                {
                    stringBuilder.Append((char)(input[j] - keyMatch));
                }

                var matchMessage = messageRegex.Match(stringBuilder.ToString());

                string planetName = matchMessage.Groups[1].Value;
                string attackOrDestroy = matchMessage.Groups[3].Value;

                if (attackOrDestroy == "A")
                {
                    attackList.Add(planetName);
                }

                else if (attackOrDestroy == "D")
                {
                    destroyList.Add(planetName);
                }
            }

            Console.WriteLine($"Attacked planets: {attackList.Count}");

            foreach (var planet in attackList.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyList.Count}");

            foreach (var planet in destroyList.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
