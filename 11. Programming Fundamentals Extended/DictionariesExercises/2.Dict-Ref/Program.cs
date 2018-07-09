namespace _2.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dict_Ref
    {
        public static void Main()
        {
            var database = new Dictionary<string, int>();
            var input = Console.ReadLine().
                Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "end")
            {
                
                string name = input[0];
                string value = input[1];

                int number;

                if (int.TryParse(value, out number))
                {
                    database[name] = number;
                }

                else
                {
                    if (database.ContainsKey(value))
                    {
                        database[name] = database[value];
                    }
                }

                input = Console.ReadLine().
                Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in database)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
