namespace _3.UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                Console.Write("\\u" + ((int)item).ToString("x4"));
            }

            Console.WriteLine();
        }
    }
}
