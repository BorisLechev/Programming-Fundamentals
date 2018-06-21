namespace Beverage_Labels
{
    using System;

    public class Beverage_Labels
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            double energyContent = (volume * energyContentPer100ml) / 100;
            double volume1 = volume / 100;
            double sugarContent = sugarContentPer100ml * volume1;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
