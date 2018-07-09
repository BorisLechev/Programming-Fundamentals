using System;

namespace _1.SoftUniReception
{
    class Program
    {
        static void Main(string[] args) //100
        {
            byte firstEmployeeEfficiency = byte.Parse(Console.ReadLine());
            byte seconsEmployeeEfficiency = byte.Parse(Console.ReadLine());
            byte thirdEmployeeEfficiency = byte.Parse(Console.ReadLine());
            int originalValue = int.Parse(Console.ReadLine());

            int studentsCount = originalValue;

            int counter = 0;

            while (true)
            {
                int allStudents = firstEmployeeEfficiency + seconsEmployeeEfficiency + thirdEmployeeEfficiency;

                if (studentsCount <= 0)
                {
                    break;
                }

                if (studentsCount >= 0)
                {
                    studentsCount -= allStudents;
                    counter++;
                }

                if (counter % 4 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
