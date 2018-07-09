namespace _1.PokeMon
{
    using System;

    public class PokeMon
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedTargets = 0;
            int halfOfTheOriginalPokePower = pokePower / 2;

            while (pokePower >= distanceBetweenTargets)
            {
                pokePower -= distanceBetweenTargets;
                pokedTargets++;

                if (exhaustionFactor != 0)
                {
                    if (pokePower == halfOfTheOriginalPokePower)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
