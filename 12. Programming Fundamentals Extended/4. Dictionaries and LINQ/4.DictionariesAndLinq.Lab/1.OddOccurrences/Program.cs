namespace _1.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var languages = new Dictionary<string, int>();

            foreach (var currentLanguage in input)
            {
                if (!languages.ContainsKey(currentLanguage))
                {
                    languages[currentLanguage] = 1;
                }

                else
                {
                    languages[currentLanguage]++;
                }
            }

            var result = new List<string>();

            foreach (var item in languages)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }

            Console.Write(string.Join(", ", result));
            Console.WriteLine();
        }
    }
}
