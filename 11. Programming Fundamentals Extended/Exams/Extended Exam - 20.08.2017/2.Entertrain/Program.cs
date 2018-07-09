namespace _2.Entertrain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Entertrain
    {
        public static void Main()
        {
            int locomotivesPower = int.Parse(Console.ReadLine());
            var wagonsAndWeight = new List<int>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "All ofboard!")
            {
                wagonsAndWeight.Add(int.Parse(input));

                if (wagonsAndWeight.Sum() > locomotivesPower)
                {
                    var closest = wagonsAndWeight.OrderBy(x => Math.Abs(x - wagonsAndWeight.Average())).First();
                    wagonsAndWeight.Remove(closest);
                }
            }

            wagonsAndWeight.Reverse();

            Console.WriteLine(string.Join(" ", wagonsAndWeight) + " " + locomotivesPower);
        }
    }
}
