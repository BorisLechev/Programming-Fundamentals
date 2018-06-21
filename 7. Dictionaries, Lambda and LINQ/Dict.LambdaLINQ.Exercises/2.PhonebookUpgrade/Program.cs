namespace _2.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            var command = Console.ReadLine().Split().ToList();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    string name = command[1];
                    string phoneNumber = command[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phoneNumber);
                    }

                    phonebook[name] = phoneNumber;
                }

                else if (command[0] == "S")
                {
                    string name = command[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }

                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                else if (command[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }
        }
    }
}
