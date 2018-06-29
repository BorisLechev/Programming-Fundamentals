namespace _1.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            decimal sets = Math.Ceiling((decimal)(numberOfGuests) / 6);
            decimal check = sets * ((2 * priceOfBananas) + (4 * priceOfEggs) + (0.2m * priceOfBerries));

            if (amountOfCash >= check)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {check:f2}lv.");
            }

            else
            {
                decimal neededMoney = check - amountOfCash;

                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}
