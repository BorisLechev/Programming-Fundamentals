namespace _5.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "print")
            {
                var command = commands.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();

                int index = 0;
                int element;

                switch (command[0])
                {
                    case "add":
                        index = int.Parse(command[1]);
                        element = int.Parse(command[2]);

                        input.Insert(index, element);
                        break;

                    case "addMany":
                        index = int.Parse(command[1]);
                        var elementsToAdd = command.Skip(2).Select(int.Parse).ToList();

                        input.InsertRange(index, elementsToAdd);
                        break;

                    case "contains":
                        element = int.Parse(command[1]);

                        Console.WriteLine(input.IndexOf(element));
                        break;

                    case "remove":
                        index = int.Parse(command[1]);

                        input.RemoveAt(index);
                        break;

                    case "shift":
                        int position = int.Parse(command[1]);

                        for (int i = 0; i < position; i++)
                        {
                            int lastElement = input[0];

                            for (int j = 0; j < input.Count - 1; j++)
                            {
                                input[j] = input[j + 1];
                            }

                            input[input.Count - 1] = lastElement;
                        }

                        break;

                    case "sumPairs":

                        var pairs = new List<int>();

                        for (int i = 0; i < input.Count - 1; i+=2)
                        {
                            pairs.Add(input[i] + input[i + 1]);
                        }

                        if (input.Count % 2 == 1)
                        {
                            pairs.Add(input[input.Count - 1]);
                        }

                        input = pairs;
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
