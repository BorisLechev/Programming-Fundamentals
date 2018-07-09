namespace _2._1HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
        public static void Main()
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();

            string messagePattern = @"^(\d+)\s<->\s([a-zA-Z\d]+)$";
            string broadcastPattern = @"^(\D+)\s<->\s([a-zA-Z\d]+)$";

            var messageRegex = new Regex(messagePattern);
            var broadcastRegex = new Regex(broadcastPattern);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                if (messageRegex.IsMatch(input))
                {
                    var match = messageRegex.Match(input);

                    string recipientCode = string.Join("", match.Groups[1].Value.Reverse());
                    string message = match.Groups[2].Value;

                    messages.Add(recipientCode + " -> " + message);
                }

                if (broadcastRegex.IsMatch(input))
                {
                    var match = broadcastRegex.Match(input);

                    var message = match.Groups[1].Value;
                    string frequency = DecryptFrequency(match.Groups[2].Value);

                    broadcasts.Add($"{frequency} -> {message}");
                }
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, broadcasts));
            }

            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, messages));
            }

            else
            {
                Console.WriteLine("None");
            }
        }

        public static string DecryptFrequency(string encryptedFrequency)
        {
            string decryptedFrequency = string.Empty;

            foreach (var currentChar in encryptedFrequency)
            {
                if (currentChar > 64 && currentChar < 91)
                {
                    decryptedFrequency += currentChar.ToString().ToLower();
                }

                else if (currentChar > 96 && currentChar < 123)
                {
                    decryptedFrequency += currentChar.ToString().ToUpper();
                }

                else
                {
                    decryptedFrequency += currentChar;
                }
            }

            return decryptedFrequency;
        }
    }
}
