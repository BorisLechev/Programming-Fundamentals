namespace _1.Snowballs
{
    using System;
    using System.Numerics;

    public class Snowballs
    {
        public static void Main()
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            short snowballSnowMax = 0;
            short snowballTimeMax = 0;
            short snowballQualityMax = 0;
            BigInteger snowballValueMax = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue < snowballValueMax)
                {
                    continue;
                }

                snowballValueMax = snowballValue;
                snowballSnowMax = snowballSnow;
                snowballTimeMax = snowballTime;
                snowballQualityMax = snowballQuality;
            }

            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}
