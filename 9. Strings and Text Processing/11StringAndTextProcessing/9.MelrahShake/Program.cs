namespace _9.MelrahShake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex == lastIndex)
                {
                    break;
                }

                Console.WriteLine("Shaked it.");

                input = input.Remove(lastIndex, pattern.Length);
                input = input.Remove(firstIndex, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);

                if (pattern.Length < 1)
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
