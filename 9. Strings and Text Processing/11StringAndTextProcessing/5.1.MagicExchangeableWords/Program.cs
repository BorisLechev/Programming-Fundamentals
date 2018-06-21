namespace _5._1.MagicExchangeableWords
{
    using System;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstWord = input[0].ToCharArray().Distinct().ToList();
            var secondWord = input[1].ToCharArray().Distinct().ToList();

            bool answer;

            if (firstWord.Count == secondWord.Count)
            {
                answer = true;
            }

            else
            {
                answer = false;
            }

            var result = answer.ToString().ToLower();

            Console.WriteLine(result);
        }
    }
}
