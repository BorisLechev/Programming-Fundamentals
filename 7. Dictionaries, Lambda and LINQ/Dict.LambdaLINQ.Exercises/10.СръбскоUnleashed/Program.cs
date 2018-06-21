namespace _10.СръбскоUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class СръбскоUnleashed
    {
        public static void Main()
        {
            var srabsko = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var currentInput = input.Split('@').ToList();

                string singer = currentInput[0];

                if (singer.Last() != ' ')
                {
                    input = Console.ReadLine();

                    continue;
                }

                singer = currentInput[0].TrimEnd();
                string venue = currentInput[1];
                var venueList = venue.Split(' ').ToList();

                if (int.TryParse(venueList[venueList.Count - 1], out int currentTicketCount))
                {
                    if (int.TryParse(venueList[venueList.Count - 2], out int currentTicketPrice))
                    {
                        venueList.RemoveAt(venueList.Count - 1);
                        venueList.RemoveAt(venueList.Count - 1);

                        string currentPlace = string.Join(" ", venueList);
                        int totalIncome = currentTicketCount * currentTicketPrice;

                        if (!srabsko.ContainsKey(currentPlace))
                        {
                            srabsko[currentPlace] = new Dictionary<string, int>();
                        }

                        if (!srabsko[currentPlace].ContainsKey(singer))
                        {
                            srabsko[currentPlace][singer] = 0;
                        }

                        srabsko[currentPlace][singer] += totalIncome;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var place in srabsko)
            {
                Console.WriteLine($"{place.Key}");

                foreach (var singer in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
