namespace _1.FindTheLetter
{
    using System;

    public class FindTheLetter
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();
            var twoElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var letter = twoElements[0];
            int occurrenceOfTheLetter = int.Parse(twoElements[1]);

            int index = -1;

            for (int i = 0; i < occurrenceOfTheLetter; i++)
            {
                index++;
                index = inputText.IndexOf(letter, index);
            }

            if (index < 0)
            {
                Console.WriteLine("Find the letter yourself!");
            }

            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
