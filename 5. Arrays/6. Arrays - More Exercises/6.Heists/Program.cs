namespace _6.Heists
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] heistInfo = Console.ReadLine().Split(' ').ToArray();

            int jewelsPrice = prices[0];
            int goldPrice = prices[1];
            int jewelsCount = 0;
            int goldCount = 0;
            double totalEarnings = 0;
            double totalExpenses = 0;

            while (heistInfo[0] != "Jail" && heistInfo[1] != "Time")
            {
                jewelsCount += heistInfo[0].Count(ch => ch == '%');
                goldCount += heistInfo[0].Count(ch => ch == '$');
                double heistsExpenses = double.Parse(heistInfo[1]);
                totalExpenses += heistsExpenses;

                heistInfo = Console.ReadLine().Split(' ').ToArray();
            }

            totalEarnings = jewelsPrice * jewelsCount + goldPrice * goldCount - totalExpenses;

            Console.WriteLine(totalEarnings >= 0
                ? $"Heists will continue. Total earnings: {totalEarnings}."
                : $"Have to find another job. Lost: {Math.Abs(totalEarnings)}.");
        }
    }
}
