namespace _3.JSONStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    public class JSONStringify
    {
        public static void Main()
        {
            var students = new List<Student>();

            StringBuilder result = new StringBuilder("[");

            string input = Console.ReadLine();

            while (input != "stringify")
            {
                var data = input.Split(new char[] { ' ', ':', '-', '>', ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                int age = int.Parse(data[1]);
                var grades = data.Skip(2).Select(int.Parse).ToList();

                Student newStudents = new Student()
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };

                students.Add(newStudents);

                input = Console.ReadLine();
            }

            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];

                result.Append("{name:\"" + student.Name + "\",age:" + student.Age + ",grades:[");
                result.Append(string.Join(", ", student.Grades) + "]}");

                if (i < students.Count - 1)
                {
                    result.Append(",");
                }
            }

            result.Append("]");

            Console.WriteLine(result);
        }
    }
}
