namespace _1.BandMembers
{
    using System;

    public class BandMembers    
    {
        public static void Main()
        {
            short membersCount = short.Parse(Console.ReadLine());
            float guitarPrice = float.Parse(Console.ReadLine());

            short vocalist = 1;
            short guitarists = (short)(membersCount / 3);
            short drummers = (short)(membersCount - guitarists - vocalist);

            float drumPrice = (float)(guitarPrice * 0.5) + guitarPrice;

            float microphonePrice = (drummers * drumPrice) - (guitarists * guitarPrice);

            float priceOfAllInstruments = drumPrice * drummers + microphonePrice * vocalist + guitarPrice * guitarists;

            float rentPerMonth = priceOfAllInstruments / membersCount;

            float rentForOneYear = rentPerMonth * 12;

            double totalExpenses = priceOfAllInstruments + rentForOneYear;

            Console.WriteLine($"Total cost: {totalExpenses:f2}lv.");
        }
    }
}
