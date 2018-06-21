namespace _3.ImmuneSystem
{
    using System;
    using System.Collections.Generic;

    public class ImmuneSystem
    {
        public static void Main()
        {
            int initialHealth = int.Parse(Console.ReadLine());
            int health = initialHealth;
            var dicForTimes = new Dictionary<string, int>();

            while (true)
            {
                string virusName = Console.ReadLine();

                if (virusName == "end")
                {
                    break;
                }

                int asciiSum = 0;

                for (int i = 0; i < virusName.Length; i++)
                {
                    asciiSum += virusName[i];
                }

                int timeToDefeatInSeconds = 0;
                int virusStrength = asciiSum / 3;

                if (dicForTimes.ContainsKey(virusName))
                {
                    timeToDefeatInSeconds = dicForTimes[virusName] * virusName.Length / 3;
                }

                else
                {
                    timeToDefeatInSeconds = virusStrength * virusName.Length;
                    dicForTimes[virusName] = virusStrength;
                }

                int virusDefeatSeconds = timeToDefeatInSeconds % 60;
                int virusDefeatMinutes = timeToDefeatInSeconds / 60;
                string time = string.Format($"{virusDefeatMinutes}m {virusDefeatSeconds}s");

                initialHealth -= timeToDefeatInSeconds;

                Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeatInSeconds} seconds");


                if (initialHealth < 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine($"{virusName} defeated in {time}.");
                Console.WriteLine($"Remaining health: {initialHealth}");

                initialHealth += (int)(initialHealth * 0.2);

                if (initialHealth > health)
                {
                    initialHealth = health;
                }
            }

            Console.WriteLine($"Final Health: {initialHealth}");
        }
    }
}
