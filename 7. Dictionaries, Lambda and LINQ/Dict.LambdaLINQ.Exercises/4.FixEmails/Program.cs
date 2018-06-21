namespace _4.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var namesWithMails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    foreach (var elements in namesWithMails)
                    {
                        Console.WriteLine($"{elements.Key} -> {elements.Value}");
                    }

                    break;
                }

                else
                {
                    string mail = Console.ReadLine();

                    if (!mail.Contains(".us") && !mail.Contains(".uk"))
                    {
                        namesWithMails.Add(name, mail);
                    }
                }
            }
        }
    }
}
