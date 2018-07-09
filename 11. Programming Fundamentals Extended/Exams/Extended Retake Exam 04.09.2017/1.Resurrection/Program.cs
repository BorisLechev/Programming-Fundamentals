namespace _1.Resurrection
{
    using System;

    public class Resurrection
    {
        public static void Main()
        {
            short amountOfPhoenixes = short.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPhoenixes; i++)
            {
                long totalLengthOfTheBody = long.Parse(Console.ReadLine());
                decimal totalWidthOfTheBody = decimal.Parse(Console.ReadLine());
                long lengthOfTheWing = long.Parse(Console.ReadLine());

                decimal totalYears = (decimal)Math.Pow(totalLengthOfTheBody, 2) * (totalWidthOfTheBody + 2 * lengthOfTheWing);
                Console.WriteLine(totalYears);
            }
        }
    }
}
