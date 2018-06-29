namespace _2._1ArrayManipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator              //10
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split(' ').ToArray();

                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        numbers = PrintExchange(index, numbers);
                        break;

                    case "max":
                    case "min":
                        var minOrOddForMinOrMax = command[1];
                        PrintMaxMin(numbers, command[0], command[1]);
                        break;

                    case "first":
                    case "last":
                        FirstAndLast(numbers, command[0], int.Parse(command[1]), command[2]);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static int[] PrintExchange(int index, int[] numbers)
        {
            if (index < 0 || index > numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            var leftPart = numbers.Take(index + 1).ToArray();
            var rightPart = numbers.Skip(index + 1).ToArray();

            var concatenateRightAndLeftPart = rightPart.Concat(leftPart).ToArray();
            return concatenateRightAndLeftPart;
        }

        public static int[] FilterForOddAndEven(int[] numbers, string evenOrOdd)
        {
            return numbers.Where(x => evenOrOdd == "even" ? x % 2 == 0 : x % 2 == 1).ToArray();
        }

        public static void PrintMaxMin(int[] numbers, string evenOrOdd, string command)
        {
            var filter = FilterForOddAndEven(numbers, evenOrOdd);

            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var result = command == "max" ? filter.Max() : filter.Min();
            Console.WriteLine(Array.LastIndexOf(numbers, result));
        }

        public static void FirstAndLast(int[] numbers, string command, int count, string evenOrOdd)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var filter = FilterForOddAndEven(numbers, evenOrOdd);

            int[] result;

            if (command == "first")
            {
                result = filter.Take(count).ToArray();
            }

            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
