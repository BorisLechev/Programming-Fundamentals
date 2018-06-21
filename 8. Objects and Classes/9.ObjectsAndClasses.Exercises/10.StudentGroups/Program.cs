namespace _10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class StudentGroups
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var cities = new List<City>();

            int cityCount = 0;

            Input(input, cities, ref cityCount);

            var groups = new List<Group>();

            foreach (var city in cities.OrderBy(x => x.CityName))
            {
                string cityName = city.CityName;
                int seatsCount = city.Seats;

                var students = city.Students.OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name).ThenBy(x => x.Mail).ToList();

                while (students.Any())
                {
                    var group = new Group();
                    group.City = city;
                    group.Students = students.Take(group.City.Seats).ToList();

                    students = students.Skip(group.City.Seats).ToList();

                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {cityCount} towns:");

            foreach (var group in groups)
            {
                string cityName = group.City.CityName;
                var students = group.Students;
                var mails = new List<string>();

                foreach (var student in students)
                {
                    mails.Add(student.Mail);
                }

                Console.WriteLine($"{cityName} => {string.Join(", ", mails)}");
            }
        }

        public static void Input(string input, List<City> cities, ref int cityCount)
        {
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    var currentInput = input.Split(new string[] { " => " },
                        StringSplitOptions.RemoveEmptyEntries).ToList();
                    var seatInput = currentInput[1].Split(' ');

                    var city = currentInput[0];
                    var seatsCount = int.Parse(seatInput[0]);

                    City cityName = new City();

                    cityName.CityName = city;
                    cityName.Seats = seatsCount;
                    cityName.Students = new List<Student>();

                    cities.Add(cityName);

                    cityCount++;
                }

                else
                {
                    var inputForStudents = input.Split(new char[] { '|' },
                        StringSplitOptions.RemoveEmptyEntries).ToList();

                    var studentName = inputForStudents[0].Trim();
                    var studentMail = inputForStudents[1].Trim();
                    var registerDate = DateTime.ParseExact(inputForStudents[2].Trim(),
                        "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student student = new Student();

                    student.Name = studentName;
                    student.Mail = studentMail;
                    student.RegistrationDate = registerDate;

                    cities.Last().Students.Add(student);
                }

                input = Console.ReadLine();
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class City
    {
        public string CityName { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Group
    {
        public City City { get; set; }
        public List<Student> Students { get; set; }
    }
}
