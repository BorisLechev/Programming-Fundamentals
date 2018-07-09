namespace _6.FilterBase
{
    using System;
    using System.Collections.Generic;

    public class FilterBase
    {
        public static void Main()
        {
            var ageDictionary = new Dictionary<string, int>();
            var salaryDictionary = new Dictionary<string, decimal>();
            var positionDictionary = new Dictionary<string, string>();

            var input = Console.ReadLine().
                Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "filter" && input[1] != "base")
            {
                string name = input[0];
                var secondData = input[1];

                int employeeAge;
                decimal employeeSalary;

                if (int.TryParse(secondData, out employeeAge))
                {
                    ageDictionary[name] = employeeAge;
                }

                else if (decimal.TryParse(secondData, out employeeSalary))
                {
                    salaryDictionary[name] = employeeSalary;
                }

                else
                {
                    positionDictionary[name] = secondData;
                }

                input = Console.ReadLine().
                    Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var caseForPrint = Console.ReadLine();

            if (caseForPrint == "Position")
            {
                foreach (var employee in positionDictionary)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            else if (caseForPrint == "Salary")
            {
                foreach (var employee in salaryDictionary)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }

            else if (caseForPrint == "Age")
            {
                foreach (var employee in ageDictionary)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
