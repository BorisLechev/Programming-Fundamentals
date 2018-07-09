namespace _5.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;

    public class Dict_Ref_Advanced
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<int>>();
            var input = Console.ReadLine().
                Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string key = input[0];
                var value = input[1].
                    Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!database.ContainsKey(key))
                {
                    database.Add(key, new List<int>());
                }

                for (int i = 0; i < value.Length; i++)
                {
                    int num;

                    if (int.TryParse(value[i], out num))
                    {
                        database[key].Add(num);
                    }

                    else
                    {
                        if (database.ContainsKey(value[i]))
                        {
                            database[key] = new List<int>(database[value[i]]);
                        }
                    }
                }

                input = Console.ReadLine().
                    Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in database)
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
