namespace _1.AnonymousThreat
{
    using System;
    using System.Linq;

    public class AnonymousThreat
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (command[0] != "3:1")
            {
                bool isMerge = true;
                bool isDivide = true;

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        isDivide = false;
                    }
                }

                else if (command[0] == "divide")
                {
                    int startIndex = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    for (int i = startIndex; i < partitions; i++)
                    {
                        isMerge = false;
                    }
                }

                if (isMerge)
                {
                    Console.Write(string.Join("", data));

                }

                else if (isDivide)
                {
                    Console.Write(string.Join(" ", data));
                }

                command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
