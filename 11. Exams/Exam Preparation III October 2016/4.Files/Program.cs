namespace _4.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class File
    {
        public string Root { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
    }

    public class Files
    {
        public static void Main()
        {
            var allFiles = ReadFiles();

            var query = Regex.Split(Console.ReadLine(), @"\s+in\s+");

            string extensionQuery = query[0];
            string rootQuery = query[1];

            if (!allFiles.ContainsKey(rootQuery))
            {
                Console.WriteLine("No");
                return;
            }

            var resultFiles = allFiles[rootQuery].Where(f => f.FileName.EndsWith(extensionQuery))
                .OrderByDescending(f => f.FileSize)
                .ThenBy(f => f.FileName).ToList();

            if (resultFiles.Any())
            {
                foreach (var file in resultFiles)
                {
                    Console.WriteLine($"{file.FileName} - {file.FileSize} KB");
                }
            }

            else
            {
                Console.WriteLine("No");
            }
        }

        public static Dictionary<string, List<File>> ReadFiles()
        {
            int number = int.Parse(Console.ReadLine());

            var allFiles = new Dictionary<string, List<File>>();

            for (int i = 0; i < number; i++)
            {
                var fullFilePath = Console.ReadLine().Split(new char[] { '\\', ';' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

                string root = fullFilePath[0];

                var fileName = fullFilePath[fullFilePath.Count - 2];

                long fileSize = long.Parse(fullFilePath[fullFilePath.Count - 1]);

                if (!allFiles.ContainsKey(root))
                {
                    allFiles[root] = new List<File>();
                }

                var filesInCurrentRoot = allFiles[root];

                var existingFile = filesInCurrentRoot.FirstOrDefault(f => f.FileName == fileName && f.Root == root);

                if (existingFile != null)
                {
                    existingFile.FileSize = fileSize;
                }

                else
                {
                    var file = new File()
                    {
                        Root = root,
                        FileName = fileName,
                        FileSize = fileSize
                    };

                    filesInCurrentRoot.Add(file);
                }
            }

            return allFiles;
        }
    }
}