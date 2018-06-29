namespace _4._1.Roli_TheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }

        public Event(string name, List<string> participants)
        {
            Name = name;
            Participants = participants;
        }
    }

    public class Roli_TheCoder
    {
        public static void Main()
        {
            var dictEvents = new Dictionary<int, Event>();


            var regex = new Regex(@"^(?<id>\d+)\s*#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z\d'-]+\s*)*)$");

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                var eventMatch = regex.Match(input);

                if (eventMatch.Success)
                {
                    int id = int.Parse(eventMatch.Groups["id"].Value);
                    string eventName = eventMatch.Groups["eventName"].Value;
                    var participants = eventMatch.Groups["participants"].Value.Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!dictEvents.ContainsKey(id))
                    {
                        dictEvents.Add(id, new Event(eventName, participants));
                    }

                    else if (dictEvents[id].Name == eventName)
                    {
                        dictEvents[id].Participants.AddRange(participants);
                        dictEvents[id].Participants.Distinct().ToList();
                    }
                }
            }

            foreach (var eventName in dictEvents.OrderByDescending(x => x.Value.Participants.Distinct().Count())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventName.Value.Name} - {eventName.Value.Participants.Distinct().Count()}");

                foreach (var participant in eventName.Value.Participants.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
