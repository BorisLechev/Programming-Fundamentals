namespace _9.IndexOfLetters
{
    using System;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] arr = Console.ReadLine().ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {arr[i] - 'a'}");
            }
        }
    }
}
