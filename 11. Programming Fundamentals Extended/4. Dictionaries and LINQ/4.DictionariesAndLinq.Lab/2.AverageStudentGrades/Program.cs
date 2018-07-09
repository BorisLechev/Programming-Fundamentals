namespace _2.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            var studentRecord = new Dictionary<string, List<double>>();
            int studentsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsNumber; i++)
            {
                var student = Console.ReadLine().Split(' ');
                string name = student[0];
                double grade = double.Parse(student[1]);

                if (!studentRecord.ContainsKey(name))
                {
                    studentRecord.Add(name, new List<double>());
                }

                studentRecord[name].Add(grade);
            }

            foreach (var student in studentRecord)
            {
                string name = student.Key;
                List<double> grades = student.Value;
                double average = grades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
