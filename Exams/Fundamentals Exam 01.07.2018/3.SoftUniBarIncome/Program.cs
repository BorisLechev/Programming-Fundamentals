namespace _3.SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;

    public class SoftUniBarIncome
    {
        public static void Main()  //70 => 100
        {
            string input = string.Empty;

            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*?<([\w]+)>[^|$%.]*?\|(\d+)\|[^|$%.]*?([\d.\d]+)\$";

            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string customer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);

                    totalPrice += count * price;

                    Console.WriteLine($"{customer}: {product} - {count * price:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
