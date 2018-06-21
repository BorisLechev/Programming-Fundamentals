namespace _2.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);

                string swap = words[i];
                words[i] = words[index];
                words[index] = swap;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
