namespace _1._1SinoTheWalker
{
    using System;
    using System.Globalization;
    using System.Numerics;

    public class SinoTheWalker  //80
    {
        public static void Main()
        {
            DateTime leavesTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            BigInteger numberOfSteps = BigInteger.Parse(Console.ReadLine());
            BigInteger secondsForEachStep = BigInteger.Parse(Console.ReadLine());

            BigInteger totalTime = numberOfSteps * secondsForEachStep;

            TimeSpan timeSpan = TimeSpan.FromSeconds((double)(totalTime));

            leavesTime += timeSpan;

            string time = string.Format(string.Format($"{leavesTime.Hour:D2}:{leavesTime.Minute:D2}:{leavesTime.Second:D2}"));
            Console.WriteLine($"Time Arrival: {time}");
        }
    }
}
