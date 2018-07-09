namespace _4.Cubic_sMessages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Cubic_sMessages
    {
        public static void Main()
        {
            string encryptedMessage = string.Empty;

            while ((encryptedMessage = Console.ReadLine()) != "Over!")
            {
                byte messageLength = byte.Parse(Console.ReadLine());

                string pattern = $@"^(\d+)([a-zA-Z]{{{messageLength}}})([^a-zA-Z]*)$";
                var match = Regex.Match(encryptedMessage, pattern);

                if (match.Success)
                {
                    string leftPart = match.Groups[1].Value;
                    string message = match.Groups[2].Value;
                    string rightPart = match.Groups[3].Value;

                    var indexes = string.Concat(leftPart, rightPart).Where(x => Char.IsDigit(x)).Select(x => x - '0');

                    StringBuilder verificationCode = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        if (index < 0 || index >= message.Length)
                        {
                            verificationCode.Append(' ');
                        }

                        else
                        {
                            verificationCode.Append(message[index]);
                        }
                    }

                    Console.WriteLine($"{message} == {verificationCode}");
                }
            }
        }
    }
}
