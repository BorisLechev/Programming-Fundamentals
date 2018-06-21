namespace MagicLetter
{
    using System;
    using System.Linq;

    public class MagicLetter
    {
        public static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            string result = string.Empty;

            for (char first = firstLetter; first <= secondLetter; first++)
            {
                for (char second = firstLetter; second <= secondLetter; second++)
                {
                    for (char third = firstLetter; third <= secondLetter; third++)
                    {
                        result = $"{first}{second}{third} ";

                        if (!result.Contains(thirdLetter))
                        {
                            Console.Write($"{result}");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
