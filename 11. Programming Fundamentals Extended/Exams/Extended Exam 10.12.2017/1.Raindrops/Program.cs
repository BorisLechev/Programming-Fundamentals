namespace _1.Raindrops
{
    using System;
    using System.Linq;

    public class Raindrops
    {
        public static void Main()
        {
            byte amountOfRegions = byte.Parse(Console.ReadLine());
            float density = float.Parse(Console.ReadLine());
            decimal regionalCoefficient = 0;
            decimal sumAllRegionalCoefficients = 0;

            for (int i = 0; i < amountOfRegions; i++)
            {
                var regionData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                long rainDropsCount = long.Parse(regionData[0]);
                short squareMeters = short.Parse(regionData[1]);

                regionalCoefficient = (decimal)rainDropsCount / squareMeters;

                sumAllRegionalCoefficients += regionalCoefficient;
            }

            if (density != 0)
            {
                sumAllRegionalCoefficients = sumAllRegionalCoefficients / (decimal)density;
            }

            Console.WriteLine($"{sumAllRegionalCoefficients:f3}");
        }
    }
}
