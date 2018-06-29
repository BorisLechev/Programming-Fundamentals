namespace _2.PokemonDon_tGo
{
    using System;
    using System.Linq;

    public class PokemonDon_tGo
    {
        public static void Main()
        {
            var distanceToPokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sumOfAllRemoves = 0;

            while (distanceToPokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int currentValue = 0;

                if (index < 0)
                {
                    currentValue = distanceToPokemons[0];
                    sumOfAllRemoves += currentValue;
                    distanceToPokemons[0] = distanceToPokemons.Last();
                }

                else if (index > distanceToPokemons.Count - 1)
                {
                    currentValue = distanceToPokemons.Last();
                    sumOfAllRemoves += currentValue;
                    distanceToPokemons[distanceToPokemons.Count - 1] = distanceToPokemons[0];
                }

                else
                {
                    currentValue = distanceToPokemons[index];
                    sumOfAllRemoves += currentValue;
                    distanceToPokemons.RemoveAt(index);
                }

                for (int i = 0; i < distanceToPokemons.Count; i++)
                {
                    if (distanceToPokemons[i] <= currentValue)
                    {
                        distanceToPokemons[i] += currentValue;
                    }

                    else
                    {
                        distanceToPokemons[i] -= currentValue;
                    }
                }
            }

            Console.WriteLine(sumOfAllRemoves);
        }
    }
}
