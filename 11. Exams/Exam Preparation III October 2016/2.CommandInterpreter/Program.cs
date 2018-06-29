namespace _2.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var elements = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (commands[0])
                {
                    case "reverse":
                        int startingIndex = int.Parse(commands[2]);
                        int countTimes = int.Parse(commands[4]);

                        elements = Reverse(elements, startingIndex, countTimes);
                        break;

                    case "sort":
                        startingIndex = int.Parse(commands[2]);
                        countTimes = int.Parse(commands[4]);

                        elements = Sort(elements, startingIndex, countTimes);
                        break;

                    case "rollLeft":
                        countTimes = int.Parse(commands[1]);

                        elements = RollLeft(elements, countTimes);
                        break;

                    case "rollRight":
                        countTimes = int.Parse(commands[1]);

                        elements = RollRight(elements, countTimes);
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", elements)}]");
        }

        public static List<string> Reverse(List<string> elements, int startingIndex, int countTimes)
        {
            if (startingIndex < 0 || startingIndex >= elements.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return elements;
            }

            if (startingIndex + countTimes < 0 || countTimes < 0 || startingIndex + countTimes - 1 >= elements.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return elements;
            }

            var firstPart = elements.Take(startingIndex).ToList();
            var reversedPart = elements.Skip(startingIndex).Take(countTimes).Reverse().ToList();
            var lastPart = elements.Skip(startingIndex + countTimes).ToList();

            return firstPart.Concat(reversedPart).Concat(lastPart).ToList();
        }

        public static List<string> Sort(List<string> elements, int startingIndex, int countTimes)
        {
            if (startingIndex < 0 || startingIndex >= elements.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return elements;
            }

            if (startingIndex + countTimes < 0 || countTimes < 0 || startingIndex + countTimes - 1 >= elements.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return elements;
            }

            var firstPart = elements.Take(startingIndex).ToList();
            var sortedPart = elements.Skip(startingIndex).Take(countTimes).OrderBy(x => x).ToList();
            var lastPart = elements.Skip(startingIndex + countTimes).ToList();

            return firstPart.Concat(sortedPart).Concat(lastPart).ToList();
        }

        public static List<string> RollLeft(List<string> elements, int countTimes)
        {
            if (countTimes < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return elements;
            }

            countTimes %= elements.Count;

            var firstPart = elements.Take(countTimes).ToList();
            var secondPart = elements.Skip(countTimes).ToList();

            return secondPart.Concat(firstPart).ToList();
        }

        public static List<string> RollRight(List<string> elements, int countTimes)
        {
            if (countTimes < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return elements;
            }

            countTimes %= elements.Count;

            var firstPart = elements.Skip(elements.Count - countTimes).ToList();
            var secondPart = elements.Take(elements.Count - countTimes).ToList();

            return firstPart.Concat(secondPart).ToList();
        }
    }
}
