namespace _2.Placeholders
{
    using System;

    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var text = input.
                    Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

                var sentence = text[0];

                var placeholders = text[1].
                    Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeholders.Length; i++)
                {
                    string currentPlaceholder = "{" + i  + "}";
                    sentence = sentence.Replace(currentPlaceholder, placeholders[i]);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}
