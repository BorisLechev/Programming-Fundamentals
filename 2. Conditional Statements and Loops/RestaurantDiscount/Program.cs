namespace RestaurantDiscount
{
    using System;

    public class RestaurantDiscount
    {
        public static void Main()
        {
            byte groupSize = byte.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            int hallPrice = 0;
            int servicePrice = 0;
            double discount = 0;
            string hall = string.Empty;

            switch (package)
            {
                case "Normal":
                    servicePrice = 500;
                    discount = 0.95;
                    break;

                case "Gold":
                    servicePrice = 750;
                    discount = 0.9;
                    break;

                case "Platinum":
                    servicePrice = 1000;
                    discount = 0.85;
                    break;
            }

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
            }

            else if (groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
            }

            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {((hallPrice + servicePrice) * discount) / groupSize:f2}$");
        }
    }
}
