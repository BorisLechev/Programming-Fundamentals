namespace _1.SinoTheWalker
{
    using System;
    using System.Numerics;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            var stepsToHome = new BigInteger(int.Parse(Console.ReadLine()));
            var timeInSecondsForEachStep = new BigInteger(int.Parse(Console.ReadLine()));

            var totalTime = stepsToHome * timeInSecondsForEachStep;

            int seconds = (int)(totalTime % 60);
            int minutes = (int)(totalTime / 60 % 60);
            int hours = (int)(totalTime / 60 / 60 % 24);

            time = time.AddSeconds(seconds);
            time = time.AddMinutes(minutes);
            time = time.AddHours(hours);

            Console.WriteLine($"Time Arrival: {time.Hour:00}:{time.Minute:00}:{time.Second:00}");
        }
    }
}
