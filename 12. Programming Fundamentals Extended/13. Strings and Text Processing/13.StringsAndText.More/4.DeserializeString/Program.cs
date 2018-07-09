namespace _4.DeserializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeserializeString
    {
        public static void Main()
        {
            var database = new SortedDictionary<int, char>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var splitedInput = input.Split(':');
                char character = splitedInput[0][0];
                var indexes = splitedInput[1].Split('/').Select(int.Parse).ToList();

                foreach (var index in indexes)
                {
                    database[index] = character;
                }

                input = Console.ReadLine();
            }

            foreach (var item in database)
            {
                Console.Write(item.Value);
            }

            Console.WriteLine();
        }
    }
}
