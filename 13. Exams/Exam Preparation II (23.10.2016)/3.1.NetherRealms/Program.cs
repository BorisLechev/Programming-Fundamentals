namespace _3._1.NetherRealms
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demonNames = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToList();

            string healthPattern = @"([^\d\+\-\*\/\.])";
            string damagePattern = @"([\+\-]*)([\d.]+)";

            for (int i = 0; i < demonNames.Count; i++)
            {
                string demonName = demonNames[i];

                int health = CalculateHealth(healthPattern, demonName);
                double damage = CalculateDamage(damagePattern, demonName);

                Console.WriteLine($"{demonName} - {health} health, {damage:f2} damage");
            }
        }

        public static int CalculateHealth(string healthPattern, string demonName)
        {
            var healthMatches = Regex.Matches(demonName, healthPattern);
            int health = 0;

            foreach (Match match in healthMatches)
            {
                health += match.Value[0];
            }

            return health;
        }

        public static double CalculateDamage(string damagePattern, string demonName)
        {
            var damageMatches = Regex.Matches(demonName, damagePattern);
            double damage = 0;

            foreach (Match match in damageMatches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (var symbol in demonName)
            {
                if (symbol == '*')
                {
                    damage *= 2;
                }

                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }
    }
}
