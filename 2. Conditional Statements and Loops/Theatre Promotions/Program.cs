using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (typeOfDay == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 12;
                    Console.WriteLine(price + "$");
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                    Console.WriteLine(price + "$");
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 15;
                    Console.WriteLine(price + "$");
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                    Console.WriteLine(price + "$");
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    price = 5;
                    Console.WriteLine(price + "$");
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                    Console.WriteLine(price + "$");
                }
            }
            if (age < 0)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
 