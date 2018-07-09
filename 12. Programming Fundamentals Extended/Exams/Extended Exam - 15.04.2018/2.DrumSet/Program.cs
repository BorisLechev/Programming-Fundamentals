namespace _2.DrumSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DrumSet
    {
        public static void Main()
        {
            double savings = double.Parse(Console.ReadLine());

            var initialQuality = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var originalQuality = new List<int>();

            for (int i = 0; i < initialQuality.Count; i++)
            {
                originalQuality.Add(initialQuality[i]);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                var hitPower = input.Split().Select(int.Parse).ToList();

                for (int i = 0; i < hitPower.Count; i++)
                {
                    for (int j = 0, k = 0; j < initialQuality.Count && k < originalQuality.Count; j++, k++)
                    {
                        initialQuality[j] -= hitPower[i];

                        if (initialQuality[j] <= 0)
                        {
                            if (savings - originalQuality[k] * 3 > 0)
                            {
                                savings -= originalQuality[k] * 3;
                                initialQuality[j] = originalQuality[k];
                            }

                            else
                            {
                                initialQuality[j] = 0;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", initialQuality.Where(x => x > 0)));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
