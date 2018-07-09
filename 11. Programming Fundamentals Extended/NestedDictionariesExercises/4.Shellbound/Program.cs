namespace _4.Shellbound
{
    using System;
    using System.Collections.Generic;

    public class Shellbound
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<int>>();
            var input = Console.ReadLine().Split(' ');

            while (input[0] != "Aggregate")
            {
                string region = input[0];
                int size = int.Parse(input[1]);

                if (!database.ContainsKey(region))
                {
                    database.Add(region, new List<int>());
                }

                if (!database[region].Contains(size))
                {
                    database[region].Add(size);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var shell in database)
            {
                string region = shell.Key;
                var size = shell.Value;

                int sum = 0;

                for (int i = 0; i < size.Count; i++)
                {
                    sum += size[i];
                }

                Console.WriteLine($"{region} -> {string.Join(", ", size)} ({sum - (sum / size.Count)})");
            }
        }
    }
}
