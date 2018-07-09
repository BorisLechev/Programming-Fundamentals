namespace _6.SentenceSplit
{
    using System;

    public class SentenceSplit
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimeter = Console.ReadLine();

            var result = sentence.Split(new string[] { delimeter }, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
