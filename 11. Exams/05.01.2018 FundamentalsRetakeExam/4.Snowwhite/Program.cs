namespace _4.Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Snowwhite
    {
        public static void Main()
        {
            var database = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                var dataAboutDwarfs = input.Split(new string[] { " <:> " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                string dwarfName = dataAboutDwarfs[0];
                string dwarfHatColor = dataAboutDwarfs[1];
                int dwarfPhysics = int.Parse(dataAboutDwarfs[2]);

                string nameHatColor = dwarfName + " " + dwarfHatColor;

                if (!database.ContainsKey(nameHatColor))
                {
                    database.Add(nameHatColor, dwarfPhysics);
                }

                else
                {
                    int oldPhysics = database[nameHatColor];

                    if (dwarfPhysics > oldPhysics)
                    {
                        database[nameHatColor] = dwarfPhysics;
                    }
                }
            }

            foreach (var dwarfFinalData in database.OrderByDescending(x => x.Value)
                .ThenByDescending(x => database.Count(y => y.Key.Split(' ')[1] == x.Key.Split(' ')[1])))
            {
                var result = dwarfFinalData.Key.Split(' ');

                string dwarfName = result[0];
                string hatColor = result[1];
                int physics = dwarfFinalData.Value;

                Console.WriteLine($"({hatColor}) {dwarfName} <-> {physics}");
            }
        }
    }
}
