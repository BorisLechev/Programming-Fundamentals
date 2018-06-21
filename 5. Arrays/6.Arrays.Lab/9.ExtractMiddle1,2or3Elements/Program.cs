namespace _9.ExtractMiddle1_2or3Elements
{
    using System;
    using System.Linq;

    public class ExtractMiddle1_2or3Elements
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (arrayOfNumbers.Length == 1)
            {
                ExtractMiddleOneElement(arrayOfNumbers);
            }

            else if (arrayOfNumbers.Length % 2 == 0)
            {
                ExtractMiddleTwoElements(arrayOfNumbers);
            }

            else if (arrayOfNumbers.Length % 2 == 1)
            {
                ExtractMiddleThreeElements(arrayOfNumbers);
            }
        }

        public static void ExtractMiddleThreeElements(int[] arrayOfNumbers)
        {
            Console.WriteLine($"{arrayOfNumbers[arrayOfNumbers.Length / 2 - 1]}, {arrayOfNumbers[arrayOfNumbers.Length / 2]}, {arrayOfNumbers[arrayOfNumbers.Length / 2 + 1]}");
        }

        public static void ExtractMiddleTwoElements(int[] arrayOfNumbers)
        {
            Console.WriteLine($"{arrayOfNumbers[arrayOfNumbers.Length / 2 - 1]}, {arrayOfNumbers[arrayOfNumbers.Length / 2]}");
        }

        public static void ExtractMiddleOneElement(int[] arrayOfNumbers)
        {
            Console.WriteLine(arrayOfNumbers[0]);
        }
    }
}
