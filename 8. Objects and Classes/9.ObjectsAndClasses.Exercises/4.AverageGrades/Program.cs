namespace _4.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grade { get; set; }
        public double Average => Grade.Average();
    }

    public class AverageGrades
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();

                var inputArg = Console.ReadLine().Split(' ');

                student.Name = inputArg[0];
                student.Grade = inputArg.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            students.Where(x => x.Average >= 5.00).
                OrderBy(x => x.Name).
                ThenByDescending(x => x.Average).ToList().
                ForEach(x => Console.WriteLine($"{x.Name} -> {x.Average:f2}"));
        }
    }
}
