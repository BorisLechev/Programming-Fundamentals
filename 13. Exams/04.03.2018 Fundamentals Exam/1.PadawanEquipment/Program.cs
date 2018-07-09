namespace _1.PadawanEquipment
{
    using System;

    public class PadawanEquipment
    {
        public static void Main()
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            byte countOfStudents = byte.Parse(Console.ReadLine());
            float priceOfLightSiber = float.Parse(Console.ReadLine());
            float priceOfRobe = float.Parse(Console.ReadLine());
            float priceOfBelts = float.Parse(Console.ReadLine());

            byte freeBelts = (byte)(countOfStudents / 6);
            float tenPercentMoreLightSabres = (float)(Math.Ceiling(countOfStudents + countOfStudents * 0.1));

            float sambreExpenses = (float)(priceOfLightSiber * tenPercentMoreLightSabres);
            float robesExpenses = priceOfRobe * countOfStudents;
            float beltExpenses = priceOfBelts * (countOfStudents - freeBelts);

            float totalExpenses = sambreExpenses + robesExpenses + beltExpenses;

            if (totalExpenses <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpenses:f2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivan Cho will need {totalExpenses - amountOfMoney:f2}lv more.");
            }
        }
    }
}
