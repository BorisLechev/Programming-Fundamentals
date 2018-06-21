namespace Miles_to_Kilometers
{
    using System;

    public class Miles_to_Kilometers
    {
        public static void Main()
        {
            double mile = 1.60934;

            double miles = double.Parse(Console.ReadLine());

            double kilometers = miles * mile;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
