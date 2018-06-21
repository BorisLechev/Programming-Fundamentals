using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double percentageDifference = GetPercentageDifference(previousPrice, currentPrice);
                bool isSignificantDifference = isThereSignificantDifference(percentageDifference, threshold);
                string message = GetMessage(currentPrice, previousPrice, percentageDifference, isSignificantDifference);
                Console.WriteLine(message);
                previousPrice = currentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double previousPrice, double percentageDifference, bool isSignificantDifference)
        {

            string message = "";
            if (percentageDifference == 0)
            {
                return string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!isSignificantDifference)
            {
                return string.Format($"MINOR CHANGE: {previousPrice} to {currentPrice} ({percentageDifference:F2}%)");
            }
            else if (isSignificantDifference && (percentageDifference > 0))
            {
                return string.Format($"PRICE UP: {previousPrice} to {currentPrice} ({percentageDifference:F2}%)");
            }
            else if (isSignificantDifference && (percentageDifference < 0))
            {
                return string.Format($"PRICE DOWN: {previousPrice} to {currentPrice} ({percentageDifference:F2}%)");
            }
            return message;
        }

        private static bool isThereSignificantDifference(double percentageDifference, double threshold)
        {

            if (Math.Abs(percentageDifference) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double GetPercentageDifference(double previousPrice, double currentPrice)
        {

            double percentageDifference = ((currentPrice - previousPrice) / previousPrice) * 100;
            return percentageDifference;
        }
    }
}
