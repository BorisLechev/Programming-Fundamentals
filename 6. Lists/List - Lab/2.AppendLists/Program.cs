namespace _2.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new char[] { '|' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new List<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                int[] elements = tokens[i].Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                result.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
