namespace _2.TrophonTheGrumpyCat
{
    using System;
    using System.Linq;

    public class TrophonTheGrumpyCat
    {
        public static void Main()
        {
            var priceRatings = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            int entryPointItem = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPriceRatings = Console.ReadLine();

            long leftSum = priceRatings.Take(entryPointItem).Where(x => IsValid(
                (int)x, (int)priceRatings[entryPointItem], typeOfItems, typeOfPriceRatings)).Sum();

            long rightSum = priceRatings.Skip(entryPointItem + 1).Where(x => IsValid(
                (int)x, (int)priceRatings[entryPointItem], typeOfItems, typeOfPriceRatings)).Sum();

            Console.WriteLine(leftSum >= rightSum ? "Left - " + leftSum : "Right - " + rightSum);
        }

        public static bool IsValidType(string typeOfItems, string typeOfPriceRatings, int number)
        {
            if (typeOfPriceRatings == "positive")
            {
                if (number > 0)
                {
                    return true;
                }

                return false;
            }

            if (typeOfPriceRatings == "negative")
            {
                if (number < 0)
                {
                    return true;
                }

                return false;
            }

            return true;
        }

        public static bool IsValid(int number, int entryPointItem, string typeOfItems, string typeOfPriceRatings)
        {
            if (typeOfItems == "cheap")
            {
                if (entryPointItem > number)
                {
                    return IsValidType(typeOfItems, typeOfPriceRatings, number);
                }
            }

            if (typeOfItems == "expensive")
            {
                if (number >= entryPointItem)
                {
                    return IsValidType(typeOfItems, typeOfPriceRatings, number);
                }
            }

            return false;
        }
    }
}
