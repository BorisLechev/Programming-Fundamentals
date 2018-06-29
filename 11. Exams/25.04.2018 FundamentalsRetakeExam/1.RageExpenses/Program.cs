namespace _1.RageExpenses
{
    using System;

    public class RageExpenses
    {
        public static void Main()
        {
            short lostGamesCount = short.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            double expensesForHeadsets = headsetPrice * (lostGamesCount / 2);
            double expensesForMouses = mousePrice * (lostGamesCount / 3);
            double expensesForKeyboards = keyboardPrice * (lostGamesCount / 6);
            double expensesForDisplays = displayPrice * (lostGamesCount / 12);

            double totalExpenses = expensesForHeadsets + expensesForMouses + expensesForKeyboards + expensesForDisplays;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
