namespace Convert_Speed_Units
{
    using System;

    public class Convert_Speed_Units
    {
        public static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            float speedMetersPerSecond = distance / totalSeconds;
            float kilometers = distance / 1000f;
            float totalHours = (seconds / 60 + minutes) / 60 + hours;
            float speedKilometersPerHour = kilometers / totalHours;
            float miles = kilometers / 1.609f;
            float speedMilesPerHour = miles / totalHours;

            Console.WriteLine(speedMetersPerSecond);
            Console.WriteLine(speedKilometersPerHour);
            Console.WriteLine(speedMilesPerHour);
        }
    }
}
