namespace _2.ArrayManipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator                   
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "exchange":
                        int index = int.Parse(commands[1]);
                        numbers = PrintExchangeElements(index, numbers);
                        break;

                    case "max":
                        PrintMax(numbers, commands);
                        break;

                    case "min":
                        PrintMin(numbers, commands);
                        break;

                    case "first":
                        int count = int.Parse(commands[1]);
                        PrintFirstOddOrEvenElements(numbers, count, commands);
                        break;

                    case "last":
                        count = int.Parse(commands[1]);
                        PrintLastOddOrEvenElements(numbers, count, commands);
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static int[] PrintExchangeElements(int index, int[] numbers)
        {
            if (index < 0 || index >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            var leftPart = numbers.Take(index + 1).ToArray();
            var rightPart = numbers.Skip(index + 1).ToArray();

            return rightPart.Concat(leftPart).ToArray();
        }

        public static void PrintMax(int[] numbers, string[] commands)
        {
            if (commands[1] == "odd")
            {
                int maxOdd = int.MinValue;
                int maxOddIndex = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1 && numbers[i] >= maxOdd)
                    {
                        maxOdd = numbers[i];
                        maxOddIndex = i;
                    }
                }

                if (maxOddIndex != -1)
                {
                    Console.WriteLine(maxOddIndex);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else if (commands[1] == "even")
            {
                int maxEven = int.MinValue;
                int maxEvenIndex = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] >= maxEven)
                    {
                        maxEven = numbers[i];
                        maxEvenIndex = i;
                    }
                }

                if (maxEvenIndex != -1)
                {
                    Console.WriteLine(maxEvenIndex);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        public static void PrintMin(int[] numbers, string[] commands)
        {
            if (commands[1] == "odd")
            {
                int minOdd = int.MaxValue;
                int minOddIndex = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1 && numbers[i] <= minOdd)
                    {
                        minOdd = numbers[i];
                        minOddIndex = i;
                    }
                }

                if (minOddIndex != -1)
                {
                    Console.WriteLine(minOddIndex);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else if (commands[1] == "even")
            {
                int minEven = int.MaxValue;
                int minEvenIndex = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] <= minEven)
                    {
                        minEven = numbers[i];
                        minEvenIndex = i;
                    }
                }

                if (minEvenIndex != -1)
                {
                    Console.WriteLine(minEvenIndex);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        public static void PrintFirstOddOrEvenElements(int[] numbers, int count, string[] commands)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            switch (commands[2])
            {
                case "even":
                    Console.WriteLine($"[{string.Join(", ", numbers.Where(x => x % 2 == 0).Take(count).ToArray())}]");
                    break;

                case "odd":
                    Console.WriteLine($"[{string.Join(", ", numbers.Where(x => x % 2 == 1).Take(count).ToArray())}]");
                    break;
            }
        }

        public static void PrintLastOddOrEvenElements(int[] numbers, int count, string[] commands)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            switch (commands[2])
            {
                case "even":
                    var output = numbers.Reverse().Where(x => x % 2 == 0).Take(count).Reverse().ToList();
                    Console.WriteLine
                        ($"[{string.Join(", ", output)}]");
                    break;

                case "odd":
                    output = numbers.Reverse().Where(x => x % 2 == 1).Take(count).Reverse().ToList();
                    Console.WriteLine($"[{string.Join(", ", output)}]");
                    break;
            }
        }
    }
}
