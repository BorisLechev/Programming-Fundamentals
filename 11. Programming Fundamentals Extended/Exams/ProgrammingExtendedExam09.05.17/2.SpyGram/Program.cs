namespace _2.SpyGram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SpyGram
    {
        public static void Main()
        {
            var messages = new Dictionary<string, List<string>>();

            string privateKey = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string pattern = @"TO:\s([A-Z]+);\sMESSAGE:\s(.*);";
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    int index = 0;
                    string sender = match.Groups[1].Value;

                    if (!messages.ContainsKey(sender))
                    {
                        messages.Add(sender, new List<string>());
                    }

                    string encryptedMessage = string.Empty;

                    for (int i = 0; i < match.Length; i++)
                    {
                        if (index > privateKey.Length - 1)
                        {
                            index = 0;
                        }

                        int digit = int.Parse(privateKey[index].ToString());
                        char symbol = (char)(match.ToString()[i] + digit);

                        encryptedMessage += symbol;
                        index++;
                    }

                    messages[sender].Add(encryptedMessage);
                }
            }

            foreach (var item in messages.OrderBy(x => x.Key))
            {
                foreach (var message in item.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
