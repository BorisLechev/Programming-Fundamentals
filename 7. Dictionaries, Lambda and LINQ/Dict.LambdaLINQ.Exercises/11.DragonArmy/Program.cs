namespace _11.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, List<double>>>();
            int numberOfDragons = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfDragons; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string typeOfDragon = input[0];
                string dragonName = input[1];

                if (input[2] == "null")
                {
                    input[2] = "45";
                }

                if (input[3] == "null")
                {
                    input[3] = "250";
                }

                if (input[4] == "null")
                {
                    input[4] = "10";
                }

                int damage = int.Parse(input[2]);
                int health = int.Parse(input[3]);
                int armor = int.Parse(input[4]);

                if (!database.ContainsKey(typeOfDragon))
                {
                    database[typeOfDragon] = new Dictionary<string, List<double>>();
                }

                if (!database[typeOfDragon].ContainsKey(dragonName))
                {
                    database[typeOfDragon].Add(dragonName, new List<double>());

                    database[typeOfDragon][dragonName].Add(0);
                    database[typeOfDragon][dragonName].Add(0);
                    database[typeOfDragon][dragonName].Add(0);
                }

                database[typeOfDragon][dragonName][0] = damage;
                database[typeOfDragon][dragonName][1] = health;
                database[typeOfDragon][dragonName][2] = armor;
            }

            foreach (var type in database)
            {
                double averageDamage = type.Value.Select(x => x.Value[0]).Average();
                double averageHealth = type.Value.Select(x => x.Value[1]).Average();
                double averageArmor = type.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
