namespace _2.KeyKeyValueValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyKeyValueValue
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();

            string startingKey = Console.ReadLine();
            string startingValue = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string inputKey = input[0];
                var inputValues = input[1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (!database.ContainsKey(inputKey))
                {
                    database.Add(inputKey, new List<string>());
                }

                foreach (var value in inputValues)
                {
                    database[inputKey].Add(value);
                }

                foreach (var currentData in database)
                {
                    string key = currentData.Key;
                    List<string> values = currentData.Value;

                    if (key == startingKey || key.Contains(startingKey))
                    {
                        Console.WriteLine($"{key}:");

                        foreach (string currentValue in values)
                        {
                            if (currentValue == startingValue || currentValue.Contains(startingValue))
                            {
                                Console.WriteLine($"-{currentValue}");
                            }
                        }
                    }
                }
            }
        }
    }
}
