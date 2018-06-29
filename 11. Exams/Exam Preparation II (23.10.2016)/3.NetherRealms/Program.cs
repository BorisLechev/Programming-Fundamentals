namespace _3.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }

    public class NetherRealms
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            var database = new SortedDictionary<string, Demon>();

            foreach (var demon in input)
            {
                var healthSymbols = demon.Where(x => !Char.IsDigit(x) && x != '+' && x != '-' && x != '*'
                && x != '/' && x != '.');

                var health = 0;

                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }

                var damagePattern = @"([+\-]*)([0-9.]+)";                  //[+\-]*[\d\.]+[\d\.]*
                MatchCollection matches = Regex.Matches(demon, damagePattern);

                double damage = 0.0;

                foreach (Match match in matches)
                {
                    var number = double.Parse(match.Value);
                    damage += number;
                }

                var specialSymbols = demon.Where(x => x == '*' || x == '/');

                foreach (var symbol in specialSymbols)
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

                database.Add(demon, new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var demon in database)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
            }
        }
    }
}
