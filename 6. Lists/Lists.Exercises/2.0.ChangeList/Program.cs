namespace _2._0.ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                int element = int.Parse(commands[1]);

                switch (commands[0])
                {
                    case "Delete":

                        input = Delete(input, element);
                        break;

                    case "Insert":

                        int position = int.Parse(commands[2]);
                        input = Insert(input, position, element);
                        break;
                }

                commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            if (commands[0] == "Odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 1)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
            }

            else if (commands[0] == "Even")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
            }

            Console.WriteLine();
        }

        public static List<int> Delete(List<int> input, int element)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == element)
                {
                    input.Remove(element);
                    i -= 1;
                }
            }

            return input;
        }

        public static List<int> Insert(List<int> input, int position, int element)
        {
            input.Insert(position, element);

            return input;
        }
    }
}
