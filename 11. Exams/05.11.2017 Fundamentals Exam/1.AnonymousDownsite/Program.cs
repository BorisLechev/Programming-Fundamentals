namespace _1.AnonymousDownsite
{
    using System;
    using System.Numerics;

    public class AnonymousDownsite
    {
        public static void Main()
        {
            byte numberOfWebsites = byte.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());

            decimal siteLoss = 0;
            decimal totalSiteLoss = 0;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                var dataAboutWebsites = Console.ReadLine().Split(' ');
                string siteName = dataAboutWebsites[0];
                Console.WriteLine(siteName);

                long siteVisits = long.Parse(dataAboutWebsites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(dataAboutWebsites[2]);

                siteLoss = siteVisits * siteCommercialPricePerVisit;

                totalSiteLoss += siteLoss;
            }

            Console.WriteLine($"Total Loss: {totalSiteLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), numberOfWebsites)}");
        }
    }
}
