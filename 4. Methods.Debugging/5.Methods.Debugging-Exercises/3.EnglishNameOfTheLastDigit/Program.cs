namespace _3.EnglishNameOfTheLastDigit
{
    using System;

    public class EnglishNameOfTheLastDigit
    {
        public static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

            int lastDigit = (int)GetLastDigit(number);

            PrintDigit(lastDigit);
        }

        public static long GetLastDigit(long number)
        {
            return number % 10;
        }

        public static void PrintDigit(long lastDigit)
        {
            var digitsArray = new string[]
                {"zero", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine" };

            Console.WriteLine(digitsArray[lastDigit]);
        }
    }
}
