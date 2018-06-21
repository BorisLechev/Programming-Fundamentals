namespace _2.CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(searchString);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(searchString, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
