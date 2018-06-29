namespace _3.HornetAssault
{
    using System;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();

            var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();

            long sumPowerOfHornets = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                else if (sumPowerOfHornets > beehives[i])
                {
                    beehives[i] = 0;
                }

                else
                {
                    beehives[i] -= sumPowerOfHornets;
                    sumPowerOfHornets -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Where(x => x > 0).ToList().Any())
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
