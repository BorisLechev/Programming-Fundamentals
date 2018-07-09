namespace _4._1.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files     //60
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, long>>();
            var fileData = new Dictionary<string, long>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string root = input[0];
                string fileNameAndExtension = input[input.Count - 2];
                long fileSize = long.Parse(input[input.Count - 1]);

                if (database.ContainsKey(root))
                {
                    database[root][fileNameAndExtension] = fileSize;
                }

                else
                {
                    fileData = new Dictionary<string, long>();

                    fileData[fileNameAndExtension] = fileSize;

                    database[root] = fileData;
                }
            }

            var query = Console.ReadLine()
                .Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string extensionQuery = query[0];
            string rootQuery = query[1];

            bool areThereResults = false;

            if (database.ContainsKey(rootQuery))
            {
                foreach (var file in database[rootQuery].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    var fileNameAndExtension = file.Key.Split('.');

                    if (fileNameAndExtension[1].Equals(extensionQuery))
                    {
                        areThereResults = true;

                        Console.WriteLine($"{file.Key} - {file.Value} KB");

                    }
                }
            }

            if (!areThereResults)
            {
                Console.WriteLine("No");
            }
        }
    }
}
