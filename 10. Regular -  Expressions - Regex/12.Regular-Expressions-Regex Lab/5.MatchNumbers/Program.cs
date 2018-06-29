namespace _5.MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchNumbers
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbersAsString = Console.ReadLine();

            var numbers = Regex.Matches(numbersAsString, pattern);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
