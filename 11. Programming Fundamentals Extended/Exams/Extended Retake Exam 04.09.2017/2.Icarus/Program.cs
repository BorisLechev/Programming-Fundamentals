namespace _2.Icarus
{
    using System;
    using System.Linq;

    public class Icarus
    {
        public static void Main()
        {
            var plane = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int startingPosition = int.Parse(Console.ReadLine());
            int initialDamage = 1;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Supernova")
            {
                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startingPosition <= 0)
                        {
                            initialDamage++;
                            startingPosition = plane.Count;
                        }

                        plane[startingPosition - 1] -= initialDamage;
                        startingPosition--;
                    }
                }

                else if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startingPosition >= plane.Count - 1)
                        {
                            initialDamage++;
                            startingPosition = -1;
                        }

                        plane[startingPosition + 1] -= initialDamage;
                        startingPosition++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
