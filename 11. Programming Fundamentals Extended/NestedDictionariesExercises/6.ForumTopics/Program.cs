namespace _6.ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();
            var input = Console.ReadLine().
                Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "filter")
            {
                string topic = input[0];
                var tags = input[1].Split(new char[] { ',', ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (!database.ContainsKey(topic))
                {
                    database.Add(topic, new List<string>());
                }

                for (int i = 0; i < tags.Length; i++)
                {
                    database[topic].Add(tags[i]);
                }

                input = Console.ReadLine().
                Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            var inputAfterFilter = Console.ReadLine().
                Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var forum in database)
            {
                string topic = forum.Key;
                var tags = forum.Value;
                tags = tags.Distinct().ToList();
                bool isContained = true;

                for (int i = 0; i < inputAfterFilter.Length; i++)
                {
                    if (!tags.Contains(inputAfterFilter[i]))
                    {
                        isContained = false;
                        break;
                    }
                }

                if (isContained)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                }
            }
        }
    }
}
