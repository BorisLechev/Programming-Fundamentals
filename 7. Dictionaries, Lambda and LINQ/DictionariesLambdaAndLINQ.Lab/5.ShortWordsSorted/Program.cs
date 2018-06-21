namespace _5.ShortWordsSorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower().
                Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']',
                    '"', '\\', '/', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).
                    OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
