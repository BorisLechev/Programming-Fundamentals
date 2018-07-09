namespace _3.MixedPhones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main()
        {
            var database = new SortedDictionary<string, long>();
            var input = Console.ReadLine().
                Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Over")
            {
                var name = input[0];
                var number = input[1];

                long result;

                if (long.TryParse(name, out result))
                {
                    database[number] = result;
                }

                else
                {
                    if (long.TryParse(number, out result))
                    {
                        database[name] = result;
                    }
                }

                input = Console.ReadLine().
                Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in database)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
