namespace Character_Stats
{
    using System;

    public class Character_Stats
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int displayHealth = maximumHealth - currentHealth;
            int displayEnergy = maximumEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: " + "|{0}{1}|", new string('|', currentHealth), new string('.', displayHealth));
            Console.WriteLine("Energy: " + "|{0}{1}|", new string('|', currentEnergy), new string('.', displayEnergy));
        }
    }
}
