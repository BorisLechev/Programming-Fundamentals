namespace _8.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class MentorGroup
    {
        public static void Main()
        {
            var database = new SortedDictionary<string, Student>();
            var input = Console.ReadLine().Split().ToList();

            while (input[0] != "end")
            {
                var dateList = new List<DateTime>();

                var username = input[0];

                if (input.Count > 1)
                {
                    dateList = input[1].Split(',')
                        .Select(x => DateTime.ParseExact(x, "dd\\/MM\\/yyyy", CultureInfo.InvariantCulture)).ToList();
                }

                if (database.ContainsKey(username))
                {
                    database[username].AttendanceDates.AddRange(dateList);
                }

                else
                {
                    Student currentStudent = new Student
                    {
                        Name = username,
                        AttendanceDates = dateList,
                        Comments = new List<string>()
                    };

                    database[username] = currentStudent;
                }

                input = Console.ReadLine().Split().ToList();
            }

            var inputAfterFirstEndOfDates = Console.ReadLine().Split('-').ToList();

            while (inputAfterFirstEndOfDates[0] != "end of comments")
            {
                if (database.ContainsKey(inputAfterFirstEndOfDates[0]))
                {
                    database[inputAfterFirstEndOfDates[0]].Comments.Add(inputAfterFirstEndOfDates[1]);
                }

                inputAfterFirstEndOfDates = Console.ReadLine().Split('-').ToList();
            }

            foreach (var student in database)
            {
                Console.WriteLine($"{student.Value.Name}"); // or student.Key

                Console.WriteLine("Comments:");

                foreach (var comments in student.Value.Comments)
                {
                    Console.WriteLine($"- {comments}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var dates in student.Value.AttendanceDates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {dates:dd\\/MM\\/yyyy}");
                }
            }
        }
    }

    public class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> AttendanceDates { get; set; }
        public string Name { get; set; }
    }
}
