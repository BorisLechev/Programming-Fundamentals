namespace _3.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            var database = new HashSet<string>();
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                string input = Console.ReadLine();

                database.Add(input);
            }

            Console.WriteLine();

            foreach (var set in database)
            {
                Console.WriteLine(set);
            }
        }
    }
}
