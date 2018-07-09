namespace _4.Roli_TheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Roli_TheCoder
    {
        public static void Main()
        {
            var eventsById = new Dictionary<int, string>();
            var events = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                if (input.Contains("#"))
                {
                    var currentEvent = input.Split(new char[] { ' ', '#' },
                        StringSplitOptions.RemoveEmptyEntries).ToList();

                    int id = int.Parse(currentEvent[0]);
                    string eventName = currentEvent[1];

                    var participants = new List<string>();

                    for (int i = 2; i < currentEvent.Count; i++)
                    {
                        participants.Add(currentEvent[i]);
                    }

                    if (!eventsById.ContainsKey(id))
                    {
                        eventsById.Add(id, eventName);
                        events.Add(eventName, participants);
                    }

                    else if (eventsById[id] == eventName)
                    {
                        events[eventName].AddRange(participants);
                    }
                }
            }

            foreach (var eventNameAndCounter in events
                .OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventNameAndCounter.Key} - {eventNameAndCounter.Value.Distinct().Count()}");

                foreach (var participants in eventNameAndCounter.Value.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine($"{participants}");
                }
            }
        }
    }
}
