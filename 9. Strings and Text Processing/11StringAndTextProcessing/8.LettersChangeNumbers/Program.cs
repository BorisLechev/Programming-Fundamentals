namespace _8.LettersChangeNumbers
{
    using System;
    using System.Linq;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                 .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            double result = 0;

            foreach (var word in words)
            {
                char first = word[0];
                char last = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (Char.IsUpper(first))
                {
                    number /= first - 64;
                }

                else
                {
                    number *= first - 96;
                }

                if (Char.IsUpper(last))
                {
                    number -= last - 64;
                }

                else
                {
                    number += last - 96;
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
