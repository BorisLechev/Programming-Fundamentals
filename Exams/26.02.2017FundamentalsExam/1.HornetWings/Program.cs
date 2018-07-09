namespace _1.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePerAThousandWingFlapsInMeters = double.Parse(Console.ReadLine());
            int enduranceOfTheHornet = int.Parse(Console.ReadLine()); //after he reached this number, he rests for 5 seconds.

            double distance = (wingFlaps / 1000) * distancePerAThousandWingFlapsInMeters;
            int restTimeInSeconds = wingFlaps / 100;
            int timeWithRest = (wingFlaps / enduranceOfTheHornet) * 5 + restTimeInSeconds;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{timeWithRest} s.");
        }
    }
}
