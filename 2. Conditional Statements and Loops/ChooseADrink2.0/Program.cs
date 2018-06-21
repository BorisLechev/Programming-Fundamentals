namespace ChooseADrink2._0
{
    using System;

    public class ChooseADrink2
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            byte quantity = byte.Parse(Console.ReadLine());

            double price = 0;

            if (profession == "Athlete")
            {
                price = 0.7;
                Console.WriteLine($"The Athlete has to pay {price * quantity:f2}.");
            }

            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1;
                Console.WriteLine($"The {profession} has to pay {quantity * price:f2}.");
            }

            else if (profession == "SoftUni Student")
            {
                price = 1.7;
                Console.WriteLine($"The SoftUni Student has to pay {price * quantity:f2}.");
            }

            else
            {
                price = 1.2;
                Console.WriteLine($"The {profession} has to pay {quantity * price:f2}.");
            }
        }
    }
}
