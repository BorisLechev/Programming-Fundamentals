namespace _1.ReverseString
{
    using System;

    public class ReverseString
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();
        }
    }
}
