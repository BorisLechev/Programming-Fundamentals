namespace _2.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            var field = new int[sizeOfTheField];
            var ladybugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var index in ladybugsIndexes)
            {
                if (index < 0 || index >= field.Length)
                {
                    continue;
                }

                field[index] = 1;
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var command = input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();

                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladybugIndex < 0 || ladybugIndex >= sizeOfTheField) //>= field.Length
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;
                int position = ladybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }

                    else if (direction == "left")
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= sizeOfTheField) //>= field.Length
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }

                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
