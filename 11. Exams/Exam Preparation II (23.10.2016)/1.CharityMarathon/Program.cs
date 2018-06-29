namespace _1.CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            short lengthOfMarathonInDays = short.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            byte averageNumberOfLaps = byte.Parse(Console.ReadLine());
            int lengthOfTheTrackInMeters = int.Parse(Console.ReadLine());
            short trackCapacity = short.Parse(Console.ReadLine());
            decimal donatedMoneyPerKilometer = decimal.Parse(Console.ReadLine());

            long maxRunners = trackCapacity * lengthOfMarathonInDays;

            if (numberOfRunners >= maxRunners)
            {
                numberOfRunners = maxRunners;
            }

            decimal moneyRaised = (numberOfRunners * averageNumberOfLaps * lengthOfTheTrackInMeters) / 1000
                    * donatedMoneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
