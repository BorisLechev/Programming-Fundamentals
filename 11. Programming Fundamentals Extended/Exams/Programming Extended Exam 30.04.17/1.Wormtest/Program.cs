namespace _1.Wormtest
{
    using System;

    public class Wormtest
    {
        public static void Main()
        {
            short wormsLengthInMeters = short.Parse(Console.ReadLine());
            float wormsWidthInCemtimeters = float.Parse(Console.ReadLine());

            int lengthInCentimeters = wormsLengthInMeters * 100;
            int remainder = (int)(lengthInCentimeters % wormsWidthInCemtimeters);
            decimal product = 0;

            if (remainder <= 0)
            {
                product = (decimal)(lengthInCentimeters * wormsWidthInCemtimeters);
                Console.WriteLine($"{product:f2}");
                return;
            }

            else
            {
                product = (decimal)(lengthInCentimeters / wormsWidthInCemtimeters) * 100;
                Console.WriteLine($"{product:f2}%");
            }
        }
    }
}
