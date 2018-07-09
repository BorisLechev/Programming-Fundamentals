namespace _2.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HornetComm
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var privateMessageList = new List<string>();
            var broadcastList = new List<string>();

            while (input[0] != "Hornet is Green")
            {
                if (input.Count != 2)
                {
                    input = Console.ReadLine()
                            .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                var firstQuery = input[0];
                var secondQuery = input[1];

                if (firstQuery.All(Char.IsDigit) && secondQuery.All(Char.IsLetterOrDigit))
                {
                    var reversingFirstQuery = firstQuery.Reverse().ToList();
                    string reversed = string.Join("", reversingFirstQuery);
                    string message = $"{reversed} -> {secondQuery}";

                    privateMessageList.Add(message);
                }

                else if (!firstQuery.All(Char.IsDigit) && secondQuery.All(Char.IsLetterOrDigit))
                {
                    StringBuilder changeTheCaseOfLetters = new StringBuilder();

                    for (int i = 0; i < secondQuery.Count(); i++)
                    {
                        if (Char.IsLower(secondQuery[i]))
                        {
                            changeTheCaseOfLetters.Append(Char.ToUpper(secondQuery[i]));
                        }

                        else if (Char.IsUpper(secondQuery[i]))
                        {
                            changeTheCaseOfLetters.Append(Char.ToLower(secondQuery[i]));
                        }

                        else
                        {
                            changeTheCaseOfLetters.Append(secondQuery[i]);
                        }
                    }

                    string broadcast = $"{changeTheCaseOfLetters} -> {firstQuery}";
                    broadcastList.Add(broadcast);
                }

                input = Console.ReadLine()
                .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcastList.Count == 0 ?
                "None" : string.Join(Environment.NewLine, broadcastList));

            Console.WriteLine("Messages:");
            Console.WriteLine(privateMessageList.Count == 0 ?
                "None" : string.Join(Environment.NewLine, privateMessageList));
        }
    }
}
