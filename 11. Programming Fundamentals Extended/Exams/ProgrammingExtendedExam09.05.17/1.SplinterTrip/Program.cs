namespace _1.SplinterTrip
{
    using System;

    public class SplinterTrip
    {
        public static void Main()
        {
            double tripDistanceInMiles = double.Parse(Console.ReadLine());
            double fuelTankCapacityInLiters = double.Parse(Console.ReadLine());
            double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistanceInMiles - milesSpentInHeavyWinds;
            double nonHeavyWindsConsumptionInLiters = milesInNonHeavyWinds * 25;
            double heavyWindsConsumptionInLiters = milesSpentInHeavyWinds * 25 * 1.5;
            double fuelConsumption = nonHeavyWindsConsumptionInLiters + heavyWindsConsumptionInLiters;
            double toleranceInLiters = (fuelConsumption * 5) / 100;
            double totalFuelConsumption = fuelConsumption + toleranceInLiters;

            double remainingFuelOrFuelNeeded = Math.Abs(fuelTankCapacityInLiters - totalFuelConsumption);

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");

            if (fuelTankCapacityInLiters >= totalFuelConsumption)
            {
                Console.WriteLine($"Enough with {remainingFuelOrFuelNeeded:f2}L to spare!");
            }

            else
            {
                Console.WriteLine($"We need {remainingFuelOrFuelNeeded:f2}L more fuel.");
            }
        }
    }
}
