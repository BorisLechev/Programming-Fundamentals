namespace Vowel_or_Digit
{
    using System;

    public class Vowel_or_Digit
    {
        public static void Main()
        {
            string symbol = Console.ReadLine();

            string vowels = "AEIOUYaeiouy";
            string digit = "0123456789";

            if (vowels.Contains(symbol))
            {
                Console.WriteLine("vowel");
            }

            else if (digit.Contains(symbol))
            {
                Console.WriteLine("digit");
            }

            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
